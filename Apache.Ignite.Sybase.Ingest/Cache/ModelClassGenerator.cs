using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Apache.Ignite.Sybase.Ingest.Common;
using Apache.Ignite.Sybase.Ingest.Parsers;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public static class ModelClassGenerator
    {
        private static readonly Lazy<string[]> Template = new Lazy<string[]>(LoadTemplate);

        private static string[] LoadTemplate()
        {
            var asmPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var codePath = Path.Combine(asmPath, "..", "..", "..", "Cache", nameof(ModelClassTemplate) + ".cs");

            return File.ReadAllLines(codePath);
        }

        public static string GenerateClass(RecordDescriptor desc)
        {
            Arg.NotNull(desc, nameof(desc));

            var template = Template.Value;
            var lines = GetLines(template, desc);

            return string.Join(Environment.NewLine, lines);
        }

        private static IEnumerable<string> GetLines(IEnumerable<string> template, RecordDescriptor desc)
        {
            foreach (var line in template)
            {
                var l = line.Trim();

                if (l.StartsWith("public class"))
                {
                    yield return line
                        .Replace(nameof(ModelClassTemplate), desc.TableName)
                        .Replace(".", "__");
                }
                else if (l.StartsWith("[QuerySqlField]"))
                {
                    foreach (var field in desc.Fields)
                    {
                        yield return line
                            .Replace(nameof(ModelClassTemplate.FieldTemplate), field.Name)
                            .Replace("string", field.Type.GetShortTypeName());
                    }
                }
                else if (l.StartsWith("writer.WriteString"))
                {
                    foreach (var field in desc.Fields)
                    {
                        yield return line
                            .Replace(nameof(ModelClassTemplate.FieldTemplate), field.Name)
                            .Replace("WriteString", field.Type.GetWriteMethodName());
                    }
                }
                else if (l.StartsWith("FieldTemplate = reader.ReadString"))
                {
                    foreach (var field in desc.Fields)
                    {
                        yield return line
                            .Replace(nameof(ModelClassTemplate.FieldTemplate), field.Name)
                            .Replace("ReadString", field.Type.GetReadMethodName());
                    }
                }
                else if (l.StartsWith("const int pos = 0"))
                {
                    foreach (var field in desc.Fields)
                    {
                        yield return line.Replace("0", field.StartPos.ToString());
                    }
                }
                else if (l.StartsWith("const int pos = 0"))
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

            switch (field.Type)
            {
                case RecordFieldType.String:
                    return $"{field.Name} = Encoding.ASCII.GetString(buffer, {pos}, {len}).TrimEnd();";

                case RecordFieldType.Long:
                    return $"{field.Name} = *(long*) (p + {pos});";

                case RecordFieldType.Double:
                    return $"{field.Name} = *(double*) (p + {pos});";

                default:
                    throw new ArgumentOutOfRangeException(nameof(field.Type), field.Type, null);
            }
        }

    }
}
