﻿using Dal;
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
        public List<WMS_Allert> Show()
        {
            return dal.Show();
        }
        /// <summary>
        /// 显示查询
        /// </summary>
        /// <param name="CName">仓库名</param>
        /// <param name="WName">类别</param>
        /// <param name="Coding">编号</param>
        /// <param name="Name">商品名</param>
        /// <returns></returns>
        public List<WMS_Allert> Mingxi(int Id)
        {
            return dal.Mingxi(Id);
        }
        /// <summary>
        /// 报警显示
        /// </summary>
        /// <returns></returns>
        public List<WMS_Allert> BaojingShow()
        {
            return dal.BaojingShow();
        }
        /// <summary>
        /// 修改上下架状态
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Update(WMS_Allert s)
        {
            return dal.Update(s);
        }
        /// <summary>
        /// 下拉
        /// </summary>
        /// <returns></returns>
        public List<WMS_Allert> Xiala()
        {
            return dal.Xiala();
        }
        /// <summary>
        /// 移库显示
        /// </summary>
        /// <returns></returns>
        public List<WMS_Allert> YiKuShow()
        {
            return dal.YiKuShow();
        }
    }
}
