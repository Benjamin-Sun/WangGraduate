using demo1.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo1.BLL
{
    /**
     * 遍历查出的列表绘制坐标点 
     * 经度：-70
     * 纬度：-10
     **/

    class DrawPoints
    {
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
            return (angle + 5) / 10 * 10;
        }

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
                Font font = new Font("Arial", 9, FontStyle.Regular);
                g.DrawString(tmp.ToString(), font, Brushes.Black, 4, 4);
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
