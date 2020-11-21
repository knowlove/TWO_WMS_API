using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Commodity
    {
        //商品序号
        public int C_Id { get; set; }
        //商品类别
        public string C_Categories { get; set; }
        //商品编码
        public string C_Coding { get; set; }
        //商品名称
        public string C_Name { get; set; }
        //库存设置外键
        public int I_Id { get; set; }
    }
}
