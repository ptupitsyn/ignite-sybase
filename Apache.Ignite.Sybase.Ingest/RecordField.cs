namespace Apache.Ignite.Sybase.Ingest
{
    public class RecordField
    {
        public RecordField(string name, string typeName, int position, int length)
        {
            Name = name;
            TypeName = typeName;
            Position = position;
            Length = length;
        }

        public string Name { get; }

        public string TypeName { get; }

        public int Position { get; }

        public int Length { get; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(TypeName)}: {TypeName}, {nameof(Position)}: {Position}, {nameof(Length)}: {Length}";
        }
    }
}