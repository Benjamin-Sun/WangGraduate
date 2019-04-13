using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo1.DAL;

namespace demo1.BLL
{
    public class Deal
    {
        private DAL.Data data = new Data();

        public List<nacarsdata01> gatAll()
        {
            return data.selectAll();
        }

        public List<nacarsdata01> getByNalt(int hight)
        {
            List<nacarsdata01> list = new List<nacarsdata01>();
            switch (hight)
            {
                case 30000:
                    list = data.selectByNalt(27500, 32500);
                    break;
                case 35000:
                    list = data.selectByNalt(32500, 37500);
                    break;
                case 40000:
                    list = data.selectByNalt(37500, 42500);
                    break;
                default:
                    list = null;
                    break;
            }
            return list;
        }
    }
}
