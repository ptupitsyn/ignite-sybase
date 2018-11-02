using System.IO;
using System.Linq;
using Apache.Ignite.Sybase.Ingest.Cache;
using JetBrains.Annotations;

namespace Apache.Ignite.Sybase.Ingest
{
    static class Program
    {
        static void Main(string[] args)
        {
            // We should saturate CPU, Network, and Disk for best perf.
            // Ideally producer/consumer with back-pressure is required: load data from disk and parse, pass to Streamer.
            // For simplicity let's just have single-threaded method to load single table, then run in parallel for multiple tables.

            // Records are fixed length. Only 3 data types are used across all tables:
            // STRING
            // INTEGER(8)
            // DOUBLE

            // Record format is defined in *.ctl files AND *.ctrl.gen files
            // Data files are *.dat.gz, and not all of them have ctl, so we should use *.ctrl.gen

            var dir = Path.GetFullPath(args?.FirstOrDefault() ?? Path.Combine("..", "..", "data"));

            // Tests.TestReadAllData(dir);
            // GenerateModels(dir);

            CacheLoader.LoadFromPath(dir);
        }

        [UsedImplicitly]
        private static void GenerateModels(string dir)
        {
            var recordDescriptors = Tests.GetRecordDescriptors(dir);

            foreach (var desc in recordDescriptors)
            {
                ModelClassGenerator.GenerateClass(desc);
            }
        }
    }
}
