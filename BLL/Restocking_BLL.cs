using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Restocking_BLL
    {
        Restocking_DAL dal = new Restocking_DAL();

        /// <summary>
        /// 补货列表
        /// </summary>
        /// <returns></returns>
        public List<Demand> GetDemands()
        {
            return dal.GetDemands();
        }

        /// <summary>
        /// 补货列表详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Demand> GetDemands(int id)
        {
            return dal.GetDemands(id);
        }

        /// <summary>
        /// 一级品类绑定下拉
        /// </summary>
        /// <returns></returns>
        public List<Catedity> GetCatedities()
        {
            return dal.GetCatedities();
        }

        /// <summary>
        /// 温区下拉绑定
        /// </summary>
        /// <returns></returns>
        public List<Warm> GetWarms()
        {
            return dal.GetWarms();
        }

        /// <summary>
        /// 门店下拉绑定
        /// </summary>
        /// <returns></returns>
        public List<Shops> GetShops()
        {
            return dal.GetShops();
        }

        /// <summary>
        /// 合格品入库
        /// </summary>
        /// <returns></returns>
        public List<Qualified> GetQualifieds()
        {
            return dal.GetQualifieds();
        }

    }
}
