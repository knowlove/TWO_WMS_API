using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dal;
namespace Bll
{
    public class WarehousesBll
    {
        //实例化DAL
        WarehousesDal dal = new WarehousesDal();
        //显示
        public List<WMS_Allert> ChuKuShow()
        {
            return dal.ChuKuShow();
        }
        //详情
        public List<WMS_Allert> ChuKuShowxq(int Id)
        {
            return dal.ChuKuShowxq(Id);
        }
    }
}
