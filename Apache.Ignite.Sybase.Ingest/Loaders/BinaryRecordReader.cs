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

        public unsafe object[] Read()
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
                var pos = field.StartPos - 1;
                var len = field.EndPos - pos;

                switch (field.Type)
                {
                    case RecordFieldType.String:
                        // All strings are ASCII, see .dat.sql files.
                        // Strings are padded with spaces (because fixed length).
                        result[index] = Encoding.ASCII.GetString(_buffer, pos, len).TrimEnd();
                        break;

                    case RecordFieldType.Long:
                        fixed (byte* p = &_buffer[pos])
                        {
                            result[index] = *(long*) p;
                        }
                        break;

                    case RecordFieldType.Double:
                        fixed (byte* p = &_buffer[pos])
                        {
                            result[index] = *(double*) p;
                        }
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return result;
        }

        public void Dispose()
        {
            _stream?.Dispose();
        }
    }
}
