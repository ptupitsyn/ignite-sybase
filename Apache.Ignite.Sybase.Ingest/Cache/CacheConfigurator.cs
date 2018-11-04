using System.Linq;
using Apache.Ignite.Core.Cache.Configuration;
using Apache.Ignite.Sybase.Ingest.Common;
using Apache.Ignite.Sybase.Ingest.Parsers;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public static class CacheConfigurator
    {
        public static CacheConfiguration GetQueryCacheConfiguration(RecordDescriptor desc)
        {
            Arg.NotNull(desc, nameof(desc));

            // Type name, cache name, table name are the same.
            var cacheName = desc.TableName;
            var typeName = desc.TableName;

            var config = new CacheConfiguration
            {
                Name = cacheName,
                QueryEntities = new[]
                {
                    new QueryEntity
                    {
                        KeyType = typeof(long),
                        ValueTypeName = typeName,
                        Fields = desc.Fields.Select(GetQueryField).ToArray()
                    }
                },
                QueryParallelism = 8
            };

            return config;
        }

        private static QueryField GetQueryField(RecordField field)
        {
            return new QueryField
            {
                Name = field.Name,
                FieldType = field.Type.GetClrType()
            };
        }
    }
}
