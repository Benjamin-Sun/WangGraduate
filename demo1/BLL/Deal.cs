using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo1.DAL;

namespace demo1.BLL
{
    public class Deal
    {
        private DAL.Data data = new Data();

        //画坐标
        public Bitmap getXY()
        {
            return new DrawXY().draw();
        }

        public Bitmap getXY2()
        {
            return new DrawXY().draw2();
        }

        //画点
        public Bitmap getPoints(string hight)
        {
            if (hight == null || hight.Equals(""))
            {
                List<nacarsdata01> list = this.getAll();
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
                List<nacarsdata01> list = this.getAll();
                return new DrawPoints().drawPoints2(list);
            }
            else
            {
                List<nacarsdata01> list = this.getByNaltAndTime(hight, time);
                return new DrawPoints().drawPoints2(list);
            }

        }

        //取得风向
        public List<PictureBox> getPictures(string hight)
        {
            if (hight == null || hight.Equals(""))
            {
                List<nacarsdata01> list = this.getAll();
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
                List<nacarsdata01> list = this.getAll();
                return new DrawPoints().getPictures2(list);
            }
            else
            {
                List<nacarsdata01> list = this.getByNaltAndTime(hight, time);
                return new DrawPoints().getPictures2(list);
            }
        }

        //查询
        public List<nacarsdata01> getAll()
        {
            return data.selectAll();
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

        //泛型查询对应表
        public List<T> getByNaltAndTime<T>(string hight, string time) where T : acarsEntities
        {
            int t;
            List<T> list = new List<T>();

            switch (time)
            {
                case "6小时内":
                    t = -6;
                    switch (hight)
                    {
                        case "FL100":
                            list = data.selectByNaltAndTime<T>(9000, 11000, t);
                            break;
                        case "FL180":
                            list = data.selectByNaltAndTime<T>(17000, 19000, t);
                            break;
                        case "FL240":
                            list = data.selectByNaltAndTime<T>(23000, 25000, t);
                            break;
                        case "FL300":
                            list = data.selectByNaltAndTime<T>(29000, 31000, t);
                            break;
                        case "FL340":
                            list = data.selectByNaltAndTime<T>(33000, 35000, t);
                            break;
                        case "FL390":
                            list = data.selectByNaltAndTime<T>(38000, 40000, t);
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
                            list = data.selectByNaltAndTime<T>(9000, 11000, t);
                            break;
                        case "FL180":
                            list = data.selectByNaltAndTime<T>(17000, 19000, t);
                            break;
                        case "FL240":
                            list = data.selectByNaltAndTime<T>(23000, 25000, t);
                            break;
                        case "FL300":
                            list = data.selectByNaltAndTime<T>(29000, 31000, t);
                            break;
                        case "FL340":
                            list = data.selectByNaltAndTime<T>(33000, 35000, t);
                            break;
                        case "FL390":
                            list = data.selectByNaltAndTime<T>(38000, 40000, t);
                            break;
                        default:
                            list = null;
                            break;
                    }
                    break;
            }
            return list;
        }

        public List<T> getAll<T>() where T : acarsEntities
        {
            return data.selectAll<T>();
        }

        //泛型画点
        public Bitmap getPointsT<T>(string hight, string time) where T : acarsEntities
        {
            if (hight == null || hight.Equals(""))
            {
                List<T> list = this.getAll<T>();
                return new DrawPoints().drawPoints2(list);
            }
            else
            {
                List<T> list = this.getByNaltAndTime<T>(hight, time);
                return new DrawPoints().drawPoints2(list);
            }

        }

        //泛型取得风向
        public List<PictureBox> getPicturesT<T>(string hight, string time) where T : acarsEntities
        {
            if (hight == null || hight.Equals(""))
            {
                List<T> list = this.getAll<T>();
                return new DrawPoints().getPictures2(list);
            }
            else
            {
                List<T> list = this.getByNaltAndTime<T>(hight, time);
                return new DrawPoints().getPictures2(list);
            }
        }

        //反射生成实例(未使用)
        private T getT<T>() where T : acarsEntities
        {
            int day = DateTime.Now.Day;

            string fullName = "DAL.nacarsdata" + day;//命名空间.类型名
            object obj = Assembly.Load("demo1.DAL").CreateInstance(fullName);//加载程序集，创建程序集里面的 命名空间.类型名 实例

            return (T)obj;
        }
    }
}
