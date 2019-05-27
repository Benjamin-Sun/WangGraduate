using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1.BLL
{
    //10-60纬度 改20-50
    //70-140经度 改100-130
    class DrawXY
    {
        Bitmap image = new Bitmap(1402, 1002); //创建位图（Draw 绘制）
        Bitmap image2 = new Bitmap(1202, 1202);

        public Bitmap draw()//创建坐标系方法
        {

            //创建Graphics类对象(Graphics 绘图)(Graphics在已知的控件上的方法)
            Graphics g = Graphics.FromImage(image);

            //定义填充图图形
            System.Drawing.Drawing2D.LinearGradientBrush brush 
                = new System.Drawing.Drawing2D.LinearGradientBrush
                (new Rectangle(0, 0, image.Width - 2, image.Height - 2), Color.Black, Color.Black, 1, false);

            //定义画笔
            Pen mypen = new Pen(brush, 1);

            //定义字体
            Font font = new Font("Arial", 9, FontStyle.Regular);

            //创建点
            PointF center_Pt = new PointF(1400, 1000);//定义原点（中心点）
            float Xaxis_length = 1400;
            float Yaxis_length = 1000;
            PointF Xaxis_Begin = new PointF(center_Pt.X - Xaxis_length, center_Pt.Y - Yaxis_length);//X轴首端点
            PointF Xaxis_EndPt = new PointF(center_Pt.X, center_Pt.Y - Yaxis_length);//X轴末端点
            PointF Yaxis_Begin = new PointF(center_Pt.X - Xaxis_length, center_Pt.Y - Yaxis_length);//Y轴首端点
            PointF Yaxis_EndPt = new PointF(center_Pt.X - Xaxis_length, center_Pt.Y);//Y轴末端点
            //①绘制由坐标对、宽度和高度指定的矩形(x, y, width, height)（绘制边框线）
            g.DrawRectangle(new Pen(Color.Black), Xaxis_Begin.X, Yaxis_Begin.Y, 1400, 1000);

            //绘制线条
            //绘制纵向线条
            //x和y为首个竖向线条的位置，i为竖向线条总数，100为竖向间隔
            float x = 0;
            for (int i = 0; i < 7; i++)
            {
                g.DrawLine(mypen, x, Yaxis_Begin.Y, x, Yaxis_EndPt.Y);
                x = x + 200;
            }
            //绘制横向线条
            float y = 0;
            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(mypen, Xaxis_Begin.X, y, Xaxis_EndPt.X, y);
                y = y + 200;
            }

            //刻度
            //x轴上对应的标记
            String[] n = { "70", "80", "90", "100", "110", "120", "130", "140" };
            //设置文字内容及输出位置（DrawString 在指定位置输出文本）
            //x和y为首个刻度的位置，i为刻度总数，100为刻度间隔
            x = 0;
            for (int i = 0; i < 8; i++)
            {
                g.DrawString(n[i].ToString(), font, Brushes.Red, x, 985);
                x = x + 197;
            }
            //y轴上对应的标记
            String[] m = { "60", "50", "40", "30", "20", "10" };
            //设置文字内容及输出位置（DrawString 在指定位置输出文本）
            y = 0;
            for (int i = 0; i < 6; i++)
            {
                g.DrawString(m[i].ToString(), font, Brushes.Red, 0, y);
                y = y + 193;
            }

            g.Dispose();

            return image;
        }

        public Bitmap draw2()//创建坐标系方法
        {

            //创建Graphics类对象(Graphics 绘图)(Graphics在已知的控件上的方法)
            Graphics g = Graphics.FromImage(image2);

            //定义填充图图形
            System.Drawing.Drawing2D.LinearGradientBrush brush
                = new System.Drawing.Drawing2D.LinearGradientBrush
                (new Rectangle(0, 0, image2.Width - 2, image2.Height - 2), Color.Black, Color.Black, 1, false);

            //定义画笔
            Pen mypen = new Pen(brush, 1);

            //定义字体
            Font font = new Font("Arial", 9, FontStyle.Regular);

            //创建点
            PointF center_Pt = new PointF(1200, 1200);//定义原点（中心点）
            float Xaxis_length = 1200;
            float Yaxis_length = 1200;
            PointF Xaxis_Begin = new PointF(center_Pt.X - Xaxis_length, center_Pt.Y - Yaxis_length);//X轴首端点
            PointF Xaxis_EndPt = new PointF(center_Pt.X, center_Pt.Y - Yaxis_length);//X轴末端点
            PointF Yaxis_Begin = new PointF(center_Pt.X - Xaxis_length, center_Pt.Y - Yaxis_length);//Y轴首端点
            PointF Yaxis_EndPt = new PointF(center_Pt.X - Xaxis_length, center_Pt.Y);//Y轴末端点
            //①绘制由坐标对、宽度和高度指定的矩形(x, y, width, height)（绘制边框线）
            g.DrawRectangle(new Pen(Color.Black), Xaxis_Begin.X, Yaxis_Begin.Y, 1200, 1200);

            //绘制线条
            //绘制纵向线条
            //x和y为首个竖向线条的位置，i为竖向线条总数，100为竖向间隔
            float x = 0;
            for (int i = 0; i < 3; i++)
            {
                g.DrawLine(mypen, x, Yaxis_Begin.Y, x, Yaxis_EndPt.Y);
                x = x + 400;
            }
            //绘制横向线条
            float y = 0;
            for (int i = 0; i < 3; i++)
            {
                g.DrawLine(mypen, Xaxis_Begin.X, y, Xaxis_EndPt.X, y);
                y = y + 400;
            }

            //刻度
            //x轴上对应的标记
            String[] n = { "100", "110", "120", "130" };
            //设置文字内容及输出位置（DrawString 在指定位置输出文本）
            //x和y为首个刻度的位置，i为刻度总数，100为刻度间隔
            x = 0;
            for (int i = 0; i < 4; i++)
            {
                g.DrawString(n[i].ToString(), font, Brushes.Red, x, 1185);
                x = x + 395;
            }
            //y轴上对应的标记
            String[] m = { "50", "40", "30", "20" };
            //设置文字内容及输出位置（DrawString 在指定位置输出文本）
            y = 0;
            for (int i = 0; i < 4; i++)
            {
                g.DrawString(m[i].ToString(), font, Brushes.Red, 0, y);
                y = y + 393;
            }

            g.Dispose();

            return image2;
        }
    }
}
