using System;
using System.IO;
using Apache.Ignite.Sybase.Ingest.Common;
using Apache.Ignite.Sybase.Ingest.Parsers;

namespace Apache.Ignite.Sybase.Ingest.Loaders
{
    public class BinaryReader : IDisposable
    {
        private readonly RecordDescriptor _recordDescriptor;
        private readonly FileStream _stream;

        public BinaryReader(RecordDescriptor recordDescriptor, FileStream stream)
        {
            _recordDescriptor = Arg.NotNull(recordDescriptor, nameof(recordDescriptor));
            _stream = Arg.NotNull(stream, nameof(stream));
        }

        public object[] Read()
        {
            foreach (var field in _recordDescriptor.Fields)
            {

            }
        }

        public void Dispose()
        {
            _stream?.Dispose();
        }
    }
}
