using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using Bll;
using G4MotnTestApi;

namespace TWO_WMS_API.Controllers
{
    public class WarehousesController : ApiController
    {
        WarehousesBll bll = new WarehousesBll();

        //显示出库
        [HttpGet]
        public IHttpActionResult ChuKuShow(int page, int rows, string CName = "", string WName = "")
        {
            List<WMS_Allert> list = bll.ChuKuShow();
            if (!string.IsNullOrEmpty(CName))
            {
                list = list.Where(s => s.CName.Contains(CName)).ToList();
            }
            if (!string.IsNullOrEmpty(WName))
            {
                list = list.Where(s => s.WName.Contains(WName)).ToList();
            }
           
            int totalCount = list.Count;
            list = list.Skip((page - 1) * rows).Take(rows).ToList();
            var model = new
            {
                total = totalCount,
                rows = list
            };
            return Ok(model);
        }
        [HttpGet]
        //详情
        public List<WMS_Allert> ChuKuShowxq(int Id)
        {
            return bll.ChuKuShowxq(Id);
        }
        //导出
        [HttpGet]
        public IHttpActionResult ExportExcel()
        {
            try
            {
                //获取所有的订单信息
                List<WMS_Allert> list = bll.ChuKuShow();             
                //导出
                ExcelHelper.ExportExcel<WMS_Allert>(list);
                return Ok(1);
            }
            catch (Exception)
            {
                return Ok(0);
            }
        }
        //导入
        [HttpPost]
        public IHttpActionResult ImportExcel()
        {
            List<WMS_Allert> list = new List<WMS_Allert>();
            try
            {
                string filePath = @"D:.xls";
                //导入
                list = ExcelHelper.ImportExcel<WMS_Allert>(filePath);
            }
            catch
            {

            }
            return Ok(list);
        }
    }
}
