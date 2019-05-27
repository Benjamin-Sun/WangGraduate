using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        //画点
        public Bitmap getPoints(string hight)
        {
            if (hight == null || hight.Equals(""))
            {
                List<nacarsdata01> list = this.gatAll();
                return new DrawPoints().drawPoints(list);
            }
            else
            {
                List<nacarsdata01> list = this.getByNalt(hight);
                return new DrawPoints().drawPoints(list);
            }
            
        }

        public Bitmap getPointsT(string hight, string time)
        {
            if (hight == null || hight.Equals(""))
            {
                List<nacarsdata01> list = this.gatAll();
                return new DrawPoints().drawPoints(list);
            }
            else
            {
                List<nacarsdata01> list = this.getByNaltAndTime(hight, time);
                return new DrawPoints().drawPoints(list);
            }

        }

        //取得风向
        public List<PictureBox> getPictures(string hight)
        {
            if (hight == null || hight.Equals(""))
            {
                List<nacarsdata01> list = this.gatAll();
                return new DrawPoints().getPictures(list);
            }
            else
            {
                List<nacarsdata01> list = this.getByNalt(hight);
                return new DrawPoints().getPictures(list);
            }
        }

        public List<PictureBox> getPicturesT(string hight, string time)
        {
            if (hight == null || hight.Equals(""))
            {
                List<nacarsdata01> list = this.gatAll();
                return new DrawPoints().getPictures(list);
            }
            else
            {
                List<nacarsdata01> list = this.getByNaltAndTime(hight, time);
                return new DrawPoints().getPictures(list);
            }
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

        public List<nacarsdata01> getByNaltAndTime(string hight, string time)
        {
            List<nacarsdata01> list = new List<nacarsdata01>();
            int t;

            switch (time)
            {
                case "6小时内":
                    t = -6;
                    switch (hight)
                    {
                        case "FL100":
                            list = data.selectByNaltAndTime(9000, 11000, t);
                            break;
                        case "FL180":
                            list = data.selectByNaltAndTime(17000, 19000, t);
                            break;
                        case "FL240":
                            list = data.selectByNaltAndTime(23000, 25000, t);
                            break;
                        case "FL300":
                            list = data.selectByNaltAndTime(29000, 31000, t);
                            break;
                        case "FL340":
                            list = data.selectByNaltAndTime(33000, 35000, t);
                            break;
                        case "FL390":
                            list = data.selectByNaltAndTime(38000, 40000, t);
                            break;
                        default:
                            list = null;
                            break;
                    }
                    break;
                case "12小时内":
                    t = -12;
                    switch (hight)
                    {
                        case "FL100":
                            list = data.selectByNaltAndTime(9000, 11000, t);
                            break;
                        case "FL180":
                            list = data.selectByNaltAndTime(17000, 19000, t);
                            break;
                        case "FL240":
                            list = data.selectByNaltAndTime(23000, 25000, t);
                            break;
                        case "FL300":
                            list = data.selectByNaltAndTime(29000, 31000, t);
                            break;
                        case "FL340":
                            list = data.selectByNaltAndTime(33000, 35000, t);
                            break;
                        case "FL390":
                            list = data.selectByNaltAndTime(38000, 40000, t);
                            break;
                        default:
                            list = null;
                            break;
                    }
                    break;
            }
            return list;
        }
    }
}
