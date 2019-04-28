using demo1.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1.BLL
{
    /**
     * 遍历查出的列表绘制坐标点 
     **/

    class DrawPoints
    {
        public Bitmap drawPoints(List<nacarsdata01> list)
        {
            Bitmap image = new Bitmap(1402, 1002);
            //Graphics g = Graphics.FromImage(image);

            for (int i = 0; i < list.Count; i++)
            {
                PointF p = new PointF(Convert.ToInt32(list[i].nlong * 20), Convert.ToInt32(list[i].nlat * 20));
                //g.DrawLine(new Pen(Color.Black, 2), p, p);
                Console.WriteLine((((int)Math.Round((Double)list[i].nlong, 2)) * 20).ToString() + " " + (((int)Math.Round((Double)list[i].nlat, 2)) * 20).ToString());

                //image.SetPixel((int)Math.Round((Double)list[i].nlong, 1) * 20,
                //    (int)Math.Round((Double)list[i].nlat, 1) * 20, Color.Red);
            }

            return image;
        }
    }
}
