using System;
using System.IO;
using System.Linq;
using CsvHelper;

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
                if (!csvReader.ReadHeader())
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
    }

    public class CtrlGenParserRecord
    {
        public string ColumnName { get; set; }
        public string ColumnDataType { get; set; }
        public string ColumnLength { get; set; }
        public string Scale { get; set; }
        public string Position { get; set; }
        public string StartPosition { get; set; }
        public string EndPosition { get; set; }
    }
}
