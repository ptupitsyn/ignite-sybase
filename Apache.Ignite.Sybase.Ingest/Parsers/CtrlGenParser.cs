using System;
using System.IO;
using System.Linq;
using CsvHelper;
using JetBrains.Annotations;

namespace Apache.Ignite.Sybase.Ingest.Parsers
{
    /// <summary>
    /// Parses ctrl.gen files.
    /// </summary>
    public class CtrlGenParser
    {
        public static RecordDescriptor Parse(string path)
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

                // TODO
                var records = csvReader.GetRecords<CtrlGenParserRecord>().ToArray();

                Console.WriteLine(records.Length);

                return null;
            }
        }


        [UsedImplicitly]
        private class CtrlGenParserRecord
        {
            // ReSharper disable InconsistentNaming
            public string column_name { get; set; }
            public string column_data_type { get; set; }
            public string column_length { get; set; }
            public string scale { get; set; }
            public string position { get; set; }
            public string start_position { get; set; }
            public string end_position { get; set; }
            // ReSharper restore InconsistentNaming
        }
    }
}
