using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Apache.Ignite.Sybase.Ingest.Parsers;

namespace Apache.Ignite.Sybase.Ingest.Common
{
    public static class Util
    {
        public static string GetInFilePath(this RecordDescriptor desc, string dir)
        {
            Arg.NotNull(desc, nameof(desc));
            Arg.NotNullOrWhitespace(dir, nameof(dir));

            var fileName = desc.InFile.Split(
                    new[] {Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar},
                    StringSplitOptions.RemoveEmptyEntries)
                .Last();

            return Path.Combine(dir, fileName + ".gz");
        }

        public static (BinaryRecordReader Reader, string FullPath) GetInFileStream(this RecordDescriptor desc, string dir)
        {
            var fullPath = desc.GetInFilePath(dir);

            if (!File.Exists(fullPath))
            {
                return (null, null);
            }

            var fileStream = File.OpenRead(fullPath);
            var gzipStream = new GZipStream(fileStream, CompressionMode.Decompress);
            var reader = new BinaryRecordReader(desc, gzipStream);

            return (reader, fullPath);
        }

        public static string ToUpperCamel(this string s)
        {
            if (string.IsNullOrEmpty(s) || !char.IsLower(s[0]))
            {
                return s;
            }

            var charArray = s.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0], CultureInfo.InvariantCulture);

            return new string(charArray);
        }
    }
}
