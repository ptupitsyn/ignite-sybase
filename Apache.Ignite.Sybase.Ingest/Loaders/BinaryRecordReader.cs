using System;
using System.IO;
using System.Text;
using Apache.Ignite.Sybase.Ingest.Common;
using Apache.Ignite.Sybase.Ingest.Parsers;

namespace Apache.Ignite.Sybase.Ingest.Loaders
{
    public class BinaryRecordReader : IDisposable
    {
        private readonly RecordDescriptor _recordDescriptor;
        private readonly Stream _stream;
        private readonly byte[] _buffer;

        public BinaryRecordReader(RecordDescriptor recordDescriptor, Stream stream)
        {
            _recordDescriptor = Arg.NotNull(recordDescriptor, nameof(recordDescriptor));
            _stream = Arg.NotNull(stream, nameof(stream));
            _buffer = new byte[_recordDescriptor.Length];
        }

        public object[] Read()
        {
            if (!_stream.CanRead)
            {
                return null;
            }

            var read = _stream.Read(_buffer, 0, _buffer.Length);

            if (read < _buffer.Length)
            {
                // EOF
                return null;
            }

            var result = new object[_recordDescriptor.Fields.Count];

            for (var index = 0; index < _recordDescriptor.Fields.Count; index++)
            {
                var field = _recordDescriptor.Fields[index];
                result[index] = ReadField(field);
            }

            return result;
        }

        private unsafe object ReadField(RecordField field)
        {
            var pos = field.StartPos - 1;
            var len = field.EndPos - pos;

            switch (field.Type)
            {
                case RecordFieldType.String:
                    // All strings are ASCII, see .dat.sql files.
                    // Strings are padded with spaces (because fixed length).
                    return Encoding.ASCII.GetString(_buffer, pos, len).TrimEnd();

                case RecordFieldType.Long:
                    fixed (byte* p = &_buffer[pos])
                    {
                        return *(long*) p;
                    }

                case RecordFieldType.Double:
                    fixed (byte* p = &_buffer[pos])
                    {
                        return *(double*) p;
                    }

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Dispose()
        {
            _stream?.Dispose();
        }
    }
}
