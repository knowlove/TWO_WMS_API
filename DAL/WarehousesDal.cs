using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Dal
{
    public class WarehousesDal
    {
        //显示
        public List<WarehousesModel> ChuKuShow()
        {
            string sql = $"select * from Storage a inner join StorageType b on a.Storage_KuWei=b.StorageType_ID inner join ReceiptsType c on c.ReceiptsTypee_ID=a.Storage_ReceiptsType inner join States d on d.States_ID=a.select * from WMS_Statement s join  Details d on d.D_Id=s.Id   join WMS_Category c on s.Id=c.CId join WMS_warehouse a on a.WId=c.CId join Warehouses w on w.WId=s.Id";
            return DBHelper.GetList<WarehousesModel>(sql);
        }
        

    }
}
