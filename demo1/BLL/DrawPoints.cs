using demo1.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo1.BLL
{
    /**
     * 遍历查出的列表绘制坐标点 
     * 经度：-70 改(100-130)
     * 纬度：-10 改(20-50)
     **/

    class DrawPoints
    {
        //画点
        public Bitmap drawPoints(List<nacarsdata01> list)
        {
            Bitmap image = new Bitmap(1402, 1002);
            int nlong;
            int nlat;

            for (int i = 0; i < list.Count; i++)
            {
                //测试使用
                //Console.WriteLine((int)((list[i].nlong - 70) * 20) + " " + (int)((list[i].nlat - 10) * 20));

                nlong = (int)(list[i].nlong - 70) * 20;
                nlat = (int)(list[i].nlat - 10) * 20;
                image.SetPixel(nlong, nlat, Color.Red);
            }
            return image;
        }

        public Bitmap drawPoints2(List<nacarsdata01> list)
        {
            Bitmap image = new Bitmap(1202, 1202);
            int nlong;
            int nlat;

            for (int i = 0; i < list.Count; i++)
            {
                //测试使用
                //Console.WriteLine((int)((list[i].nlong - 70) * 20) + " " + (int)((list[i].nlat - 10) * 20));

                nlong = (int)(list[i].nlong - 100) * 40;
                nlat = (int)(list[i].nlat - 20) * 40;
                image.SetPixel(nlong, nlat, Color.Red);
            }
            return image;
        }

        //泛型画点
        public Bitmap drawPoints2<T>(List<T> list) where T : acarsEntities
        {
            Bitmap image = new Bitmap(1202, 1202);
            int nlong;
            int nlat;

            for (int i = 0; i < list.Count; i++)
            {
                //获取泛型对象中的属性值
                Type type = typeof(T);
                PropertyInfo proInfonlong = type.GetProperty("nlong");
                PropertyInfo proInfonlat = type.GetProperty("nlat");

                double tlong = (double)proInfonlong.GetValue(list[i]);
                double tlat = (double)proInfonlat.GetValue(list[i]);

                nlong = (int)(tlong - 100) * 40;
                nlat = (int)(tlat - 20) * 40;

                Console.WriteLine(nlong + " " + nlat);

                //测试使用
                //Console.WriteLine((int)((list[i].nlong - 70) * 20) + " " + (int)((list[i].nlat - 10) * 20));
                //Console.WriteLine(list[i].nlong);
                //Console.WriteLine(list[i].nlat);

                //nlong = (list[i].nlong - 100) * 40;
                //nlat = (list[i].nlat - 20) * 40;
                image.SetPixel(nlong, nlat, Color.Red);
            }
            return image;
        }

        //画风向标
        public List<PictureBox> getPictures(List<nacarsdata01> list)
        {
            int nlong;
            int nlat;
            int windDir;
            int windSpe;
            int? tmp;
            List<PictureBox> picBoxList = new List<PictureBox>();

            for (int i = 0; i < list.Count; i++)
            {
                nlong = (int)(list[i].nlong - 70) * 20;
                nlat = (int)(list[i].nlat - 10) * 20;
                windDir = (int)list[i].nwinddirection;
                windSpe = (int)list[i].nwindspeed;
                tmp = (int?)list[i].ntemperature;
                if (tmp.Equals("") || tmp.Equals(null))
                {
                    tmp = 0;
                }

                PictureBox box = new PictureBox();
                box.Location = new Point(nlong, nlat);
                box.Name = "pictureBox" + (4 + i).ToString();
                box.Size = new Size(20, 20);
                box.Image = getRotateImage
                    (Image.FromFile(Application.StartupPath + "\\Icons\\" + getWindSpe(windSpe) + ".png"),
                    getRotateAngle(windDir), tmp);
                box.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxList.Add(box);
            }

            return picBoxList;
        }

        public List<PictureBox> getPictures2(List<nacarsdata01> list)
        {
            int nlong;
            int nlat;
            int windDir;
            int windSpe;
            int? tmp;
            List<PictureBox> picBoxList = new List<PictureBox>();

            for (int i = 0; i < list.Count; i++)
            {
                nlong = (int)(list[i].nlong - 100) * 40;
                nlat = (int)(list[i].nlat - 20) * 40;
                windDir = (int)list[i].nwinddirection;
                windSpe = (int)list[i].nwindspeed;
                tmp = (int?)list[i].ntemperature;
                //if (tmp.Equals("") || tmp.Equals(null))
                //{
                //    tmp = 0;
                //}

                PictureBox box = new PictureBox();
                box.Location = new Point(nlong, nlat);
                box.Name = "pictureBox" + (4 + i).ToString();
                box.Size = new Size(40, 40);
                box.Image = getRotateImage
                    (Image.FromFile(Application.StartupPath + "\\Icons\\" + getWindSpe(windSpe) + ".png"),
                    getRotateAngle(windDir), tmp);
                box.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxList.Add(box);
            }

            return picBoxList;
        }

        //泛型画风向标
        public List<PictureBox> getPictures2<T>(List<T> list)where T : acarsEntities
        {
            int nlong;
            int nlat;
            int windDir;
            int windSpe;
            int? tmp;
            List<PictureBox> picBoxList = new List<PictureBox>();

            for (int i = 0; i < list.Count; i++)
            {
                Type type = typeof(T);
                PropertyInfo proInfonlong = type.GetProperty("nlong");
                PropertyInfo proInfonlat = type.GetProperty("nlat");
                PropertyInfo proInfonwdr = type.GetProperty("nwinddirection");
                PropertyInfo proInfonwsp = type.GetProperty("nwindspeed");
                PropertyInfo proInfontmp = type.GetProperty("ntemperature");

                double tlong = (double)proInfonlong.GetValue(list[i]);
                double tlat = (double)proInfonlat.GetValue(list[i]);
                double twdr = (int)proInfonwdr.GetValue(list[i]);
                double twsp = (double)proInfonwsp.GetValue(list[i]);
                double? ttmp = (double?)proInfontmp.GetValue(list[i]);

                nlong = (int)(tlong - 100) * 40;
                nlat = (int)(tlat - 20) * 40;
                windDir = (int)twdr;
                windSpe = (int)twsp;
                tmp = (int?)ttmp;

                Console.WriteLine("nlong:" + nlong + " " + "nlat:" + nlat + " " + "windDir:" + windDir + " " + "windSpe:" + windSpe + " " + "tmp:" + tmp + " ");

                PictureBox box = new PictureBox();
                box.Location = new Point(nlong, nlat);
                box.Name = "pictureBox" + (4 + i).ToString();
                box.Size = new Size(40, 40);
                box.Image = getRotateImage
                    (Image.FromFile(Application.StartupPath + "\\Icons\\" + getWindSpe(windSpe) + ".png"),
                    getRotateAngle(windDir), tmp);
                box.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxList.Add(box);
            }

            return picBoxList;
        }

        //计算图片路径
        private string getWindSpe(int num)
        {
            int spe = (int)Math.Floor((num + 2.5) / 5) * 5;
            if (spe == 0)
            {
                return 5.ToString();
            }
            else
            {
                return spe.ToString();
            }
        }

        //计算旋转角度
        private int getRotateAngle(int angle)
        {
            return (angle - 90 + 5) / 10 * 10;
        }

        //旋转图片
        private Image getRotateImage(Image img, int angle, int? tmp)
        {
            angle = angle % 360;//弧度转换
            double radian = angle * Math.PI / 180.0;
            double cos = Math.Cos(radian);
            double sin = Math.Sin(radian);
            //原图的宽和高
            int w = img.Width;
            int h = img.Height;
            int W = (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));
            int H = (int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));
            //目标位图
            Image dsImage = new Bitmap(W, H, img.PixelFormat);
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(dsImage))
            {
                Font font = new Font("Arial", 10, FontStyle.Regular);
                if (!tmp.Equals("") || !tmp.Equals(null))
                {
                    if (tmp < 0)
                    {
                        tmp = Math.Abs((int)tmp);
                        g.DrawString(tmp.ToString(), font, Brushes.Black, 4, 4);
                    }
                    else
                    {
                        g.DrawString("+" + tmp.ToString(), font, Brushes.Black, 4, 4);
                    }
                }
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //计算偏移量
                Point Offset = new Point((W - w) / 2, (H - h) / 2);
                //构造图像显示区域：让图像的中心与窗口的中心点一致
                Rectangle rect = new Rectangle(Offset.X, Offset.Y, w, h);
                Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
                g.TranslateTransform(center.X, center.Y);
                g.RotateTransform(360 - angle);
                //恢复图像在水平和垂直方向的平移
                g.TranslateTransform(-center.X, -center.Y);
                g.DrawImage(img, rect);
                //重至绘图的所有变换
                g.ResetTransform();
                g.Save();
            }
            return dsImage;
        }
    }
}
