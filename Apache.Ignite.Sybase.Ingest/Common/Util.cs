using System;
using System.Globalization;
using System.IO;
using System.Linq;
using Apache.Ignite.Sybase.Ingest.Cache;
using Apache.Ignite.Sybase.Ingest.Parsers;
using ICSharpCode.SharpZipLib.GZip;

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
                .Last()
                .Replace(".ctrl.gen", ".dat");

            return Path.Combine(dir, fileName + ".gz");
        }

        public static string[] GetDataFilePaths(this RecordDescriptor desc, string dir)
        {
            Arg.NotNull(desc, nameof(desc));
            Arg.NotNullOrWhitespace(dir, nameof(dir));

            var fileName = desc.InFile.Split(
                    new[] {Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar},
                    StringSplitOptions.RemoveEmptyEntries)
                .Last()
                .Replace(".ctrl.gen", ".*.gz");

            return Directory.GetFiles(dir, fileName);
        }

        public static (BinaryRecordReader Reader, string FullPath) GetInFileStream(this RecordDescriptor desc, string dir)
        {
            // TODO: Some tables can be in multiple files.
            var fullPath = desc.GetInFilePath(dir);

            if (!File.Exists(fullPath))
            {
                return (null, fullPath);
            }

            var reader = GetBinaryRecordReader(desc, fullPath);

            return (reader, fullPath);
        }

        public static BinaryRecordReader GetBinaryRecordReader(this RecordDescriptor desc, string fullPath)
        {
            var fileStream = File.OpenRead(fullPath);
            // var gzipStream = new GZipStream(fileStream, CompressionMode.Decompress);
            var gzipStream = new GZipInputStream(fileStream);

            return new BinaryRecordReader(desc, gzipStream);
        }

        public static Type GetModelType(this RecordDescriptor desc)
        {
            var typeName = "Apache.Ignite.Sybase.Ingest.Cache." + ModelClassGenerator.GetClassName(desc.TableName);
            var type = Type.GetType(typeName);

            if (type == null)
            {
                throw new Exception("Model class not found: " + typeName);
            }

            return type;
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
