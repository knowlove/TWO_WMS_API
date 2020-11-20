using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        //序号
        public int P_Id { get; set; }
        //产品类别
        public string P_Categories { get; set; }
        //产品编码
        public string P_Coding { get; set; }
        //产品名称
        public string P_Name { get; set; }
        //产品规格
        public string P_Specifications { get; set; }
        //计量单位
        public string P_Unit { get; set; }
        //库存设置外键
        public int I_Id { get; set; }
    }
}
