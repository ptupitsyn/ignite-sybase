using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Apache.Ignite.Sybase.Ingest
{
    public static class DdlParser
    {
        private static readonly Regex TableRegex = new Regex(@"create table (.*?) \(", RegexOptions.Compiled);


        public static TableDefinition ParseDdl(string path)
        {
            var text = File
                .ReadAllLines(path)
                .Where(l => !l.StartsWith("-"))
                .TakeWhile(l => !l.EndsWith(";"))
                .ToList();

            var tableName = TableRegex.Match(text[0]).Groups[1].Value;

            if (string.IsNullOrWhiteSpace(tableName))
            {
                return null;
            }

            var columns = text
                .Skip(1)
                .Select(l =>
                {
                    var parts = l.Split(new[] {" ", "(", ")"}, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length != 3)
                    {
                        return null;
                    }

                    return new ColumnDefinition(parts[0], parts[1], parts[2]);
                })
                .Where(c => c != null)
                .ToList();

            return new TableDefinition(tableName, columns);
        }

    }
}
