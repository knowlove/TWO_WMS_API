using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Restocking_DAL
    {
        StringBuilder builder = new StringBuilder();
        /// <summary>
        /// 补货列表
        /// </summary>
        /// <returns></returns>
        public List<Demand> GetDemands()
        {
            return DBHelper.GetList<Demand>(builder.Append("select * from Demand d join Catedity ct on ct.Ct_Id=d.Ct_Id join Shops s on s.S_Id=d.S_Id join Category c on c.C_Id=d.C_Id order by d.D_Id desc").ToString());
        }

        /// <summary>
        /// 补货列表详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Demand> GetDemands(int id)
        {
            string sql = $"select * from Demand d join Catedity ct on ct.Ct_Id=d.Ct_Id join Shops s on s.S_Id=d.S_Id join Category c on c.C_Id=d.C_Id where d.D_Id='{id}' order by d.D_Id desc";
            return DBHelper.GetList<Demand>(sql);
        }

        /// <summary>
        /// 一级品类绑定下拉
        /// </summary>
        /// <returns></returns>
        public List<Catedity> GetCatedities()
        {
            return DBHelper.GetList<Catedity>(builder.Append("select * from Catedity").ToString());
        }

        /// <summary>
        /// 温区下拉绑定
        /// </summary>
        /// <returns></returns>
        public List<Warm> GetWarms()
        {
            return DBHelper.GetList<Warm>(builder.Append("select * from Warm").ToString());
        }

        /// <summary>
        /// 门店下拉绑定
        /// </summary>
        /// <returns></returns>
        public List<Shops> GetShops()
        {
            return DBHelper.GetList<Shops>(builder.Append("select * from Shops").ToString());
        }

        /// <summary>
        /// 合格品入库
        /// </summary>
        /// <returns></returns>
        public List<Qualified> GetQualifieds()
        {
            return DBHelper.GetList<Qualified>(builder.Append("select * from Qualified q join Shops s on s.S_Id=q.S_Id join Warm wa on wa.Wa_Id=q.Wa_Id order by q.Q_Id desc").ToString());
        }

    }
}
