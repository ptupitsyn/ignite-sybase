using System.IO;
using System.Linq;
using Apache.Ignite.Sybase.Ingest.Cache;
using Apache.Ignite.Sybase.Ingest.Parsers;
using JetBrains.Annotations;
using NLog;
using NLog.Config;
using NLog.Targets;

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

            ConfigureLogger();
            var dir = Path.GetFullPath(args?.FirstOrDefault() ?? Path.Combine("..", "..", "data"));

            // Tests.TestReadFactPostdataMon(dir);
            // GenerateModels(dir);

            CacheLoader.LoadFromPath(dir);
        }

        [UsedImplicitly]
        private static void GenerateModels(string dir)
        {
            // var recordDescriptors = Tests.GetRecordDescriptors(dir);
            var recordDescriptors = CtrlGenParser.ParseAll(dir);

            foreach (var desc in recordDescriptors)
            {
                ModelClassGenerator.GenerateClass(desc);
            }
        }

        private static void ConfigureLogger()
        {
            var config = new LoggingConfiguration();

            var fileTarget = new FileTarget("file") { FileName = "ignite-sybase-loader.log" };
            var consoleTarget = new ConsoleTarget("console");

            config.AddRule(LogLevel.Info, LogLevel.Fatal, consoleTarget);
            config.AddRule(LogLevel.Info, LogLevel.Fatal, fileTarget);

            LogManager.Configuration = config;
        }
    }
}
