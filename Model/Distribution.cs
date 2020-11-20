using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Distribution
    {
        //序号
        public int D_Id { get; set; }
        //周转筐编号
        public string D_Coding { get; set; }
        //温区外键
        public int Wa_Id { get; set; }
        //商品数量
        public int D_Number { get; set; }
        //配送自提点
        public string D_Point { get; set; }
        //温区名称
        public string Wa_Name { get; set; }
    }
}
