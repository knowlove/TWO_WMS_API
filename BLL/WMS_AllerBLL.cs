using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class WMS_AllerBLL
    {
        WMS_AllertDAL dal = new WMS_AllertDAL();
        /// <summary>
        /// 显示查询
        /// </summary>
        /// <param name="CName">仓库名</param>
        /// <param name="WName">类别</param>
        /// <param name="Coding">编号</param>
        /// <param name="Name">商品名</param>
        /// <returns></returns>
        public List<WMS_Allert> Show(string CName = "", string WName = "", string Coding = "", string Name = "")
        {
            return dal.Show(CName, WName, Coding, Name);
        }
    }
}
