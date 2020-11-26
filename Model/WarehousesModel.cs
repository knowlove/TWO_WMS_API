using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WarehousesModel
    {
        public int WId         { get; set; }
        public string WType       { get; set; }
        public DateTime WTime       { get; set; }
        public string WGoods      { get; set; }
        public string WCompletion { get; set; }

    }
}
