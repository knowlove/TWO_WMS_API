using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WMS_Allert
    {
        public int WId { get; set; }                  //仓库id
        public string WName { get; set; }               //仓库
        public int CId { get; set; }                   //类别ID
        public string CName { get; set; }                //类别名
        public int Id { get; set; }                     //序号
        public int WarehouseId { get; set; }                //所在仓库id
        public int CategoryId { get; set; }                //产品品类id
        public string Coding { get; set; }                //产品编号
        public string Name { get; set; }                    //产品名称
        public string Specification { get; set; }                //产品规格
        public string Unit { get; set; }                    //计量单位
        public string Quantity { get; set; }                    //库存数量
        public string Congelation { get; set; }                //冻结数量
        public string Available { get; set; }                //可用库存
        public string Production { get; set; }                //生产二部
        public string Inventory { get; set; }                //库存下限
        public string Below { get; set; }                //低于安全库存
        public string Merchandise { get; set; }                //产品信息
        public DateTime Manufacture { get; set; }                      //生产日期
        public DateTime Valid { get; set; }                    //有效期至
        public string Expiration { get; set; }                    //剩余保质期
        public string Shelf { get; set; }                    //剩余货架期
        public int Static { get; set; }                    //上架下架
        public int Type { get; set; }                             //类型 0为废品，1为商品，2为产品

    }
}
