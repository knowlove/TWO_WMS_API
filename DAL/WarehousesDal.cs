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
        public List<WMS_Allert> ChuKuShow()
        {
            string sql = $"select * from WMS_Statement s join  Details d on d.D_Id=s.Id   join WMS_Category c on s.Id=c.CId join WMS_warehouse a on a.WId=c.CId join Warehouses w on w.WId=s.Id";
            return DBHelper.GetList<WMS_Allert>(sql);
        }
        //详情
        public List<WMS_Allert> ChuKuShowxq(int Id)
        {
            string sql = $"select * from WMS_Statement s join  Details d on d.D_Id=s.Id   join WMS_Category c on s.Id=c.CId join WMS_warehouse a on a.WId=c.CId join Warehouses w on w.WId=s.Id where Id={Id}";
            return DBHelper.GetList<WMS_Allert>(sql);
        }

    }
}
