using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dal;
namespace Bll
{
   public  class rukubll
    {
        Ruku dal = new Ruku();
        public List<rukuzong> show()
        {
            return dal.show();
        }
        public List<rukuzong> showxq(int Q_Id)
        {
            return dal.showxq(Q_Id);
        }
    }
}
