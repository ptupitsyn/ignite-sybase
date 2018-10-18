using System.Collections.Generic;

namespace Apache.Ignite.Sybase.Ingest
{
    public class TableDefinition
    {
        public TableDefinition(string name, IReadOnlyList<ColumnDefinition> columns)
        {
            Name = name;
            Columns = columns;
        }

        public string Name { get; }

        public IReadOnlyList<ColumnDefinition> Columns { get; }
    }
}
