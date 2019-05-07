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

                PictureBox box = new PictureBox();
                box.Location = new Point(nlong, nlat);
                box.Name = "pictureBox4";
                box.Size = new Size(10, 10);
                box.TabIndex = 3;
                box.TabStop = false;

            }

            return image;
        }
    }
}
