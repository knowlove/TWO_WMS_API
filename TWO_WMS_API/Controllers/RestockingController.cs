using Bll;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TWO_WMS_API.Controllers
{
    public class RestockingController : ApiController
    {
        Restocking_BLL bll = new Restocking_BLL();

        /// <summary>
        /// 补货列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Demand> GetDemands(string Bm = "", string Mc = "")
        {
            List<Demand> list = bll.GetDemands();
            try
            {
                if (!string.IsNullOrEmpty(Bm))
                {
                    list = list.Where(s => s.D_Order.Contains(Bm)).ToList();
                }
                if (!string.IsNullOrEmpty(Mc))
                {
                    list = list.Where(s => s.D_Specifications.Contains(Mc)).ToList();
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("出现错误");
            }

            return list;
        }

        /// <summary>
        /// 补货列表详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Demand> GetDemands(int id)
        {
            return bll.GetDemands(id);
        }

        /// <summary>
        /// 一级品类绑定下拉
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Catedity> GetCatedities()
        {
            return bll.GetCatedities();
        }

        /// <summary>
        /// 温区下拉绑定
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Warm> GetWarms()
        {
            return bll.GetWarms();
        }

        /// <summary>
        /// 门店下拉绑定
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Shops> GetShops()
        {
            return bll.GetShops();
        }

        /// <summary>
        /// 合格品入库
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Qualified> GetQualifieds()
        {
            return bll.GetQualifieds();
        }
    }
}
