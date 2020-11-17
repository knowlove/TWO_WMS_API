using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;
using Model;
using Newtonsoft.Json;

namespace TWO_WMS_API.Controllers
{
    public class WMS_AlaetrController : ApiController
    {
        WMS_AllerBLL bl = new WMS_AllerBLL();
        /// <summary>
        /// 显示查询
        /// </summary>
        /// <param name="CName">仓库名</param>
        /// <param name="WName">类别</param>
        /// <param name="Coding">编号</param>
        /// <param name="Name">商品名</param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult Show(int page,int rows, string CName = "", string WName = "", string Coding = "", string Name = "")
        {
            List<WMS_Allert> list = bl.Show();
            if (!string.IsNullOrEmpty(CName))
            {
                list = list.Where(s => s.CName.Contains(CName)).ToList();
            }
            if (!string.IsNullOrEmpty(WName))
            {
                list = list.Where(s => s.WName.Contains(WName)).ToList();
            }
            if (!string.IsNullOrEmpty(Coding))
            {
                list = list.Where(s => s.Coding.Contains(Coding)).ToList();
            }
            if (!string.IsNullOrEmpty(Name))
            {
                list = list.Where(s => s.Name.Contains(Name)).ToList();
            }
            int totalCount = list.Count();
            list = list.Skip((page - 1) * rows).Take(rows).ToList();
            var model = new
            {
                taotal = totalCount,
                rows=list
            };
            return Ok(model);
        }
        [HttpGet]
        /// <summary>
        /// 修改上下架状态
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Update(WMS_Allert s)
        {
            return bl.Update(s);
        }
        [HttpGet]
        /// <summary>
        /// 下拉
        /// </summary>
        /// <returns></returns>
        public List<WMS_Allert> Xiala()
        {
            return bl.Xiala();
        }
    }
}
