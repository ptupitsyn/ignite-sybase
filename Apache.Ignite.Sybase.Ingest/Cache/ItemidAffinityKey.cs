using System;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Affinity;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class ItemidAffinityKey : IBinarizable
    {
        public long Key { get; set; }

        [AffinityKeyMapped]
        [QuerySqlField(Name = "itemid", IsIndexed = true)]
        public long Itemid { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("key", Key);
            writer.WriteLong("itemid", Itemid);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Key = reader.ReadLong("key");
            Itemid = reader.ReadLong("itemid");
        }
    }
}
