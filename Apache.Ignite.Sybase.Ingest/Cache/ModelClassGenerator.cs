using System;
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

            return string.Join(Environment.NewLine, template);
        }
    }
}
