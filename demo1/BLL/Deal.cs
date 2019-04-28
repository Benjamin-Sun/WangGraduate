using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Bitmap getXY()
        {
            return new DrawXY().draw();
        }

        public List<nacarsdata01> gatAll()
        {
            return data.selectAll();
        }

        public Bitmap getPoints()
        {
            List<nacarsdata01> list = this.gatAll();

            return new DrawPoints().drawPoints(list);
        }

        public List<nacarsdata01> getByNalt(string hight)
        {
            List<nacarsdata01> list = new List<nacarsdata01>();
            switch (hight)
            {
                case "FL100":
                    list = data.selectByNalt(9000, 11000);
                    break;
                case "FL180":
                    list = data.selectByNalt(17000, 19000);
                    break;
                case "FL240":
                    list = data.selectByNalt(23000, 25000);
                    break;
                case "FL300":
                    list = data.selectByNalt(29000, 31000);
                    break;
                case "FL340":
                    list = data.selectByNalt(33000, 35000);
                    break;
                case "FL390":
                    list = data.selectByNalt(38000, 40000);
                    break;
                default:
                    list = null;
                    break;
            }
            return list;
        }
    }
}
