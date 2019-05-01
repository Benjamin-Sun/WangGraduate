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
     * 经度：-70
     * 纬度：-10
     **/

    class DrawPoints
    {
        public Bitmap drawPoints(List<nacarsdata01> list)
        {
            Bitmap image = new Bitmap(1402, 1002);
            //Graphics g = Graphics.FromImage(image);

            for (int i = 0; i < list.Count; i++)
            {
                //PointF p = new PointF((int)((list[i].nlong - 70) * 20), (int)((list[i].nlat - 10) * 20));
                Console.WriteLine((int)((list[i].nlong - 70) * 20) + " " + (int)((list[i].nlat - 10) * 20));

                //g.DrawLine(new Pen(Color.Red, 2), p, p);
                image.SetPixel((int)(list[i].nlong - 70) * 20, (int)(list[i].nlat - 10) * 20, Color.Red);
            }

            return image;
        }
    }
}
