﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using Dal;
namespace TWO_WMS_API.Controllers
{
    public class OrderController : ApiController
    {
        Order_Dal Od = new Order_Dal();
        // 显示查询
        [HttpGet]
        public IHttpActionResult Show(int page, int rows, string DhCgdh = "", string DhGys = "", string DhName = "", string DhPl = "", string DhType = "")
        {
            List<Order_Model> list = Od.Show();
            if (!string.IsNullOrEmpty(DhCgdh))
            {
                list = list.Where(s => s.DhCgdh.Contains(DhCgdh)).ToList();
            }
            if (!string.IsNullOrEmpty(DhGys))
            {
                list = list.Where(s => s.DhGys.Contains(DhGys)).ToList();
            }
            if (!string.IsNullOrEmpty(DhPl))
            {
                list = list.Where(s => s.DhPl.Contains(DhPl)).ToList();
            }
            if (!string.IsNullOrEmpty(DhName))
            {
                list = list.Where(s => s.DhName.Contains(DhName)).ToList();
            }
            if (!string.IsNullOrEmpty(DhType))
            {
                list = list.Where(s => s.DhType.Contains(DhType)).ToList();
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
        // 明细
        [HttpGet]
        public List<Order_Model> Mingxi(int Id)
        {
            return Od.Mingxi(Id);
        }
        // 明细
        [HttpPost]
        public List<Order_Model> Del(int Id)
        {
            return Od.DelOrder(Id);
        }
        //修改
        [HttpPost]
        public int UpOrder(   string Cgsl, string Cgdj, string Je, string Sl,  string Bz, string id)
        {
            return Od.UpOrder(  Cgsl, Cgdj, Je, Sl,  Bz, id);
        }
        public int AddOrder(string DhCgdh, string DhGys, string DhPl, string DhRq, string DhName, string DhType, string DhYlbm, string DhYlmc, string DhWq, string DhYlGg, string DhCgsl, string DhBz, string DhHq, string DhJe, string DhSl, string DhDj)
        {

            return Od.AddOrder(DhCgdh, DhGys, DhPl, DhRq, DhName, DhType, DhYlbm, DhYlmc, DhWq, DhYlGg, DhCgsl, DhBz, DhHq, DhJe, DhSl, DhDj);

        }
        public List<Plb> GetPl(string Bm, string Mc, int Id)
        {

            string sql = $"select * from Plb where 1=1";
            if (Mc != "")
            {
                sql += $" and Mc  like '%" + Mc + "%'";

            }
            if (Bm != null)
            {
                sql += $" and Bm  like '%" + Bm + "%'";
            }
            if (Id != 0)
            {
                sql += $" and Id= Id";
            }
            return DBHelper.GetList<Plb>(sql);


        }
    }
}
