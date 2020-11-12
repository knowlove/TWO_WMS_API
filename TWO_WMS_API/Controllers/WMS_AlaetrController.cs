using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;
using Model;
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
        public List<WMS_Allert> Show(string CName = "", string WName = "", string Coding = "", string Name = "")
        {
            return bl.Show(CName, WName, Coding, Name);
        }
    }
}
