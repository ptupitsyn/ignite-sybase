// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class Posoutletitems : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "retailer_id")] public long RetailerId { get; set; }
        [QuerySqlField(Name = "retailer_item_id")] public long RetailerItemId { get; set; }
        [QuerySqlField(Name = "business_id")] public long BusinessId { get; set; }
        [QuerySqlField(Name = "npd_item_id")] public long NpdItemId { get; set; }
        [QuerySqlField(Name = "itemnumber")] public long Itemnumber { get; set; }
        [QuerySqlField(Name = "status")] public long Status { get; set; }
        [QuerySqlField(Name = "retailer_item_desc")] public string RetailerItemDesc { get; set; }
        [QuerySqlField(Name = "retailer_item_brand")] public string RetailerItemBrand { get; set; }
        [QuerySqlField(Name = "retailer_item_department")] public string RetailerItemDepartment { get; set; }
        [QuerySqlField(Name = "retailer_item_class")] public string RetailerItemClass { get; set; }
        [QuerySqlField(Name = "retailer_item_model_number")] public string RetailerItemModelNumber { get; set; }
        [QuerySqlField(Name = "retailer_sku")] public string RetailerSku { get; set; }
        [QuerySqlField(Name = "retailer_item_division")] public string RetailerItemDivision { get; set; }
        [QuerySqlField(Name = "retailer_item_subdepartment")] public string RetailerItemSubdepartment { get; set; }
        [QuerySqlField(Name = "retailer_item_subclass")] public string RetailerItemSubclass { get; set; }
        [QuerySqlField(Name = "retailer_item_upc")] public string RetailerItemUpc { get; set; }
        [QuerySqlField(Name = "retailer_item_department_name")] public string RetailerItemDepartmentName { get; set; }
        [QuerySqlField(Name = "retailer_item_class_name")] public string RetailerItemClassName { get; set; }
        [QuerySqlField(Name = "added_date")] public string AddedDate { get; set; }
        [QuerySqlField(Name = "updated_date")] public string UpdatedDate { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("retailer_id", RetailerId);
            writer.WriteLong("retailer_item_id", RetailerItemId);
            writer.WriteLong("business_id", BusinessId);
            writer.WriteLong("npd_item_id", NpdItemId);
            writer.WriteLong("itemnumber", Itemnumber);
            writer.WriteLong("status", Status);
            writer.WriteString("retailer_item_desc", RetailerItemDesc);
            writer.WriteString("retailer_item_brand", RetailerItemBrand);
            writer.WriteString("retailer_item_department", RetailerItemDepartment);
            writer.WriteString("retailer_item_class", RetailerItemClass);
            writer.WriteString("retailer_item_model_number", RetailerItemModelNumber);
            writer.WriteString("retailer_sku", RetailerSku);
            writer.WriteString("retailer_item_division", RetailerItemDivision);
            writer.WriteString("retailer_item_subdepartment", RetailerItemSubdepartment);
            writer.WriteString("retailer_item_subclass", RetailerItemSubclass);
            writer.WriteString("retailer_item_upc", RetailerItemUpc);
            writer.WriteString("retailer_item_department_name", RetailerItemDepartmentName);
            writer.WriteString("retailer_item_class_name", RetailerItemClassName);
            writer.WriteString("added_date", AddedDate);
            writer.WriteString("updated_date", UpdatedDate);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            RetailerId = reader.ReadLong("retailer_id");
            RetailerItemId = reader.ReadLong("retailer_item_id");
            BusinessId = reader.ReadLong("business_id");
            NpdItemId = reader.ReadLong("npd_item_id");
            Itemnumber = reader.ReadLong("itemnumber");
            Status = reader.ReadLong("status");
            RetailerItemDesc = reader.ReadString("retailer_item_desc");
            RetailerItemBrand = reader.ReadString("retailer_item_brand");
            RetailerItemDepartment = reader.ReadString("retailer_item_department");
            RetailerItemClass = reader.ReadString("retailer_item_class");
            RetailerItemModelNumber = reader.ReadString("retailer_item_model_number");
            RetailerSku = reader.ReadString("retailer_sku");
            RetailerItemDivision = reader.ReadString("retailer_item_division");
            RetailerItemSubdepartment = reader.ReadString("retailer_item_subdepartment");
            RetailerItemSubclass = reader.ReadString("retailer_item_subclass");
            RetailerItemUpc = reader.ReadString("retailer_item_upc");
            RetailerItemDepartmentName = reader.ReadString("retailer_item_department_name");
            RetailerItemClassName = reader.ReadString("retailer_item_class_name");
            AddedDate = reader.ReadString("added_date");
            UpdatedDate = reader.ReadString("updated_date");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                RetailerId = *(long*) (p + 0);
                RetailerItemId = *(long*) (p + 8);
                BusinessId = *(long*) (p + 16);
                NpdItemId = *(long*) (p + 24);
                Itemnumber = *(long*) (p + 32);
                Status = *(long*) (p + 40);
                RetailerItemDesc = Encoding.ASCII.GetString(buffer, 48, 200).TrimEnd();
                RetailerItemBrand = Encoding.ASCII.GetString(buffer, 248, 128).TrimEnd();
                RetailerItemDepartment = Encoding.ASCII.GetString(buffer, 376, 64).TrimEnd();
                RetailerItemClass = Encoding.ASCII.GetString(buffer, 440, 64).TrimEnd();
                RetailerItemModelNumber = Encoding.ASCII.GetString(buffer, 504, 128).TrimEnd();
                RetailerSku = Encoding.ASCII.GetString(buffer, 632, 64).TrimEnd();
                RetailerItemDivision = Encoding.ASCII.GetString(buffer, 696, 64).TrimEnd();
                RetailerItemSubdepartment = Encoding.ASCII.GetString(buffer, 760, 64).TrimEnd();
                RetailerItemSubclass = Encoding.ASCII.GetString(buffer, 824, 64).TrimEnd();
                RetailerItemUpc = Encoding.ASCII.GetString(buffer, 888, 20).TrimEnd();
                RetailerItemDepartmentName = Encoding.ASCII.GetString(buffer, 908, 512).TrimEnd();
                RetailerItemClassName = Encoding.ASCII.GetString(buffer, 1420, 512).TrimEnd();
                AddedDate = Encoding.ASCII.GetString(buffer, 1932, 14).TrimEnd();
                UpdatedDate = Encoding.ASCII.GetString(buffer, 1946, 14).TrimEnd();
            }
        }
    }
}
