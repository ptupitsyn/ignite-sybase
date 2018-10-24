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
            writer.WriteLong(nameof(RetailerId), RetailerId);
            writer.WriteLong(nameof(RetailerItemId), RetailerItemId);
            writer.WriteLong(nameof(BusinessId), BusinessId);
            writer.WriteLong(nameof(NpdItemId), NpdItemId);
            writer.WriteLong(nameof(Itemnumber), Itemnumber);
            writer.WriteLong(nameof(Status), Status);
            writer.WriteString(nameof(RetailerItemDesc), RetailerItemDesc);
            writer.WriteString(nameof(RetailerItemBrand), RetailerItemBrand);
            writer.WriteString(nameof(RetailerItemDepartment), RetailerItemDepartment);
            writer.WriteString(nameof(RetailerItemClass), RetailerItemClass);
            writer.WriteString(nameof(RetailerItemModelNumber), RetailerItemModelNumber);
            writer.WriteString(nameof(RetailerSku), RetailerSku);
            writer.WriteString(nameof(RetailerItemDivision), RetailerItemDivision);
            writer.WriteString(nameof(RetailerItemSubdepartment), RetailerItemSubdepartment);
            writer.WriteString(nameof(RetailerItemSubclass), RetailerItemSubclass);
            writer.WriteString(nameof(RetailerItemUpc), RetailerItemUpc);
            writer.WriteString(nameof(RetailerItemDepartmentName), RetailerItemDepartmentName);
            writer.WriteString(nameof(RetailerItemClassName), RetailerItemClassName);
            writer.WriteString(nameof(AddedDate), AddedDate);
            writer.WriteString(nameof(UpdatedDate), UpdatedDate);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            RetailerId = reader.ReadLong(nameof(RetailerId));
            RetailerItemId = reader.ReadLong(nameof(RetailerItemId));
            BusinessId = reader.ReadLong(nameof(BusinessId));
            NpdItemId = reader.ReadLong(nameof(NpdItemId));
            Itemnumber = reader.ReadLong(nameof(Itemnumber));
            Status = reader.ReadLong(nameof(Status));
            RetailerItemDesc = reader.ReadString(nameof(RetailerItemDesc));
            RetailerItemBrand = reader.ReadString(nameof(RetailerItemBrand));
            RetailerItemDepartment = reader.ReadString(nameof(RetailerItemDepartment));
            RetailerItemClass = reader.ReadString(nameof(RetailerItemClass));
            RetailerItemModelNumber = reader.ReadString(nameof(RetailerItemModelNumber));
            RetailerSku = reader.ReadString(nameof(RetailerSku));
            RetailerItemDivision = reader.ReadString(nameof(RetailerItemDivision));
            RetailerItemSubdepartment = reader.ReadString(nameof(RetailerItemSubdepartment));
            RetailerItemSubclass = reader.ReadString(nameof(RetailerItemSubclass));
            RetailerItemUpc = reader.ReadString(nameof(RetailerItemUpc));
            RetailerItemDepartmentName = reader.ReadString(nameof(RetailerItemDepartmentName));
            RetailerItemClassName = reader.ReadString(nameof(RetailerItemClassName));
            AddedDate = reader.ReadString(nameof(AddedDate));
            UpdatedDate = reader.ReadString(nameof(UpdatedDate));
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
