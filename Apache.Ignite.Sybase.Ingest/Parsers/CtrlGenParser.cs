using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using JetBrains.Annotations;

namespace Apache.Ignite.Sybase.Ingest.Parsers
{
    /// <summary>
    /// Parses ctrl.gen files.
    /// </summary>
    public static class CtrlGenParser
    {
        public static IEnumerable<RecordDescriptor> ParseAll(string dir)
        {
            var ctlFiles = Directory.GetFiles(dir, "*.ctrl.gen");

            return ctlFiles.Select(Parse);
        }

        private static RecordDescriptor Parse(string path)
        {
            using (var reader = File.OpenText(path))
            using (var csvReader = new CsvReader(reader))
            {
                if (!csvReader.Read() || !csvReader.ReadHeader())
                {
                    throw new Exception("Failed to read CSV header: " + path);
                }

                if (csvReader.Context.HeaderRecord.Length != 7)
                {
                    throw new Exception("Failed to read CSV header, unexpected field count: " + csvReader.Context.RawRecord);
                }

                var records = csvReader.GetRecords<CtrlGenParserRecord>().ToArray();
                if (!records.Any())
                {
                    throw new Exception("File appears to have no fields: " + path);
                }


                var recordLength = records.Last().end_position;
                var sumLength = records.Sum(r => r.column_length);
                if (recordLength != sumLength)
                {
                    throw new Exception($"Record length check failed: last field end pos = {recordLength}, " +
                                        $"sum of field lengths = {sumLength}");
                }

                var fields = records.Select(GetField).ToArray();

                var tableName = path
                    .Replace(".ctrl.gen", string.Empty, StringComparison.InvariantCultureIgnoreCase)
                    .Split(".")
                    .Last();

                return new RecordDescriptor(recordLength, fields, path, tableName);
            }
        }

        private static RecordField GetField(CtrlGenParserRecord arg) =>
            new RecordField(arg.column_name, arg.column_data_type, arg.start_position, arg.end_position);

        [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
        private class CtrlGenParserRecord
        {
            // ReSharper disable InconsistentNaming
            public string column_name { get; set; }
            public string column_data_type { get; set; }
            public int column_length { get; set; }
            public int scale { get; set; }
            public int position { get; set; }
            public int start_position { get; set; }
            public int end_position { get; set; }
            // ReSharper restore InconsistentNaming
        }
    }
}
