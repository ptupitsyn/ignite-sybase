using System;
using System.IO;
using System.Text;
using Apache.Ignite.Core.Binary;
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

        public IBinaryObjectBuilder ReadAsBinaryObject(string typeName, IBinary binary)
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

            var result = binary.GetBuilder(typeName);

            foreach (var field in _recordDescriptor.Fields)
            {
                ReadField(result, field);
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

        private unsafe void ReadField(IBinaryObjectBuilder builder, RecordField field)
        {
            var pos = field.StartPos - 1;
            var len = field.EndPos - pos;

            switch (field.Type)
            {
                case RecordFieldType.String:
                {
                    // All strings are ASCII, see .dat.sql files.
                    // Strings are padded with spaces (because fixed length).
                    var val = Encoding.ASCII.GetString(_buffer, pos, len).TrimEnd();
                    builder.SetStringField(field.Name, val);
                    break;
                }

                case RecordFieldType.Long:
                    fixed (byte* p = &_buffer[pos])
                    {
                        builder.SetLongField(field.Name, *(long*) p);
                        break;
                    }

                case RecordFieldType.Double:
                    fixed (byte* p = &_buffer[pos])
                    {
                        builder.SetDoubleField(field.Name, *(double*) p);
                        break;
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(field.Type), field.Type, "Invalid field type");
            }
        }

        public void Dispose()
        {
            _stream?.Dispose();
        }
    }
}
