using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Apache.Ignite.Sybase.Ingest.Common;
using Apache.Ignite.Sybase.Ingest.Parsers;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public static class ModelClassGenerator
    {
        private static readonly string AsmPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly Lazy<string[]> Template = new Lazy<string[]>(LoadTemplate);

        private static string[] LoadTemplate()
        {
            var codePath = Path.Combine(AsmPath, "..", "..", "..", "Cache", nameof(ModelClassTemplate) + ".cs");

            return File.ReadAllLines(codePath);
        }

        public static void GenerateClass(RecordDescriptor desc)
        {
            Arg.NotNull(desc, nameof(desc));

            var template = Template.Value;
            var className = GetClassName(desc.TableName);
            var lines = GetLines(template, desc, className);
            var targetPath = Path.Combine(AsmPath, "..", "..", "..", "Models", className + ".cs");

            File.WriteAllLines(targetPath, lines);
        }

        private static IEnumerable<string> GetLines(
            IEnumerable<string> template,
            RecordDescriptor desc,
            string className)
        {
            foreach (var line in template)
            {
                var l = line.Trim();

                if (l.StartsWith("public class"))
                {
                    yield return line.Replace(nameof(ModelClassTemplate), className);
                }
                else if (l.StartsWith("[QuerySqlField"))
                {
                    foreach (var field in desc.Fields)
                    {
                        yield return line
                            .Replace(nameof(ModelClassTemplate.FieldTemplate), GetPropertyName(field.Name))
                            .Replace("SQL_NAME", field.Name)
                            .Replace("string", field.Type.GetShortTypeName());
                    }
                }
                else if (l.StartsWith("writer.WriteString"))
                {
                    foreach (var field in desc.Fields)
                    {
                        yield return line
                            .Replace(nameof(ModelClassTemplate.FieldTemplate), GetPropertyName(field.Name))
                            .Replace("WriteString", field.Type.GetWriteMethodName());
                    }
                }
                else if (l.StartsWith("FieldTemplate = reader.ReadString"))
                {
                    foreach (var field in desc.Fields)
                    {
                        yield return line
                            .Replace(nameof(ModelClassTemplate.FieldTemplate), GetPropertyName(field.Name))
                            .Replace("ReadString", field.Type.GetReadMethodName());
                    }
                }
                else if (l.StartsWith("FieldTemplate = Encoding.ASCII.GetString"))
                {
                    foreach (var field in desc.Fields)
                    {
                        yield return new string(' ', 16) + GetReadFromRecordBufferCode(field);
                    }
                }
                else
                {
                    yield return line;
                }
            }
        }

        private static string GetReadFromRecordBufferCode(RecordField field)
        {
            var pos = field.StartPos - 1;
            var len = field.EndPos - pos;

            var propertyName = GetPropertyName(field.Name);

            switch (field.Type)
            {
                case RecordFieldType.String:
                    return $"{propertyName} = Encoding.ASCII.GetString(buffer, {pos}, {len}).TrimEnd();";

                case RecordFieldType.Long:
                    return $"{propertyName} = *(long*) (p + {pos});";

                case RecordFieldType.Double:
                    return $"{propertyName} = *(double*) (p + {pos});";

                default:
                    throw new ArgumentOutOfRangeException(nameof(field.Type), field.Type, null);
            }
        }

        private static string GetClassName(string tableName)
        {
            return GetPropertyName(tableName.Split(".").Last());
        }

        private static string GetPropertyName(string fieldName)
        {
            return string.Concat(fieldName.Split("_").Select(x => x.ToUpperCamel()));
        }
    }
}
