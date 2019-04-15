using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1.UI
{
    class DrawXY
    {
        int width = 800, height = 350; //定义画布大小
        Bitmap image = new Bitmap(950, 500); //创建位图（Draw 绘制）

        public Bitmap draw(int[] xbuf, int[] ybuf)//创建坐标系方法（xbuf,ybuf绘制点坐标数组）
        {

            //创建Graphics类对象(Graphics 绘图)(Graphics在已知的控件上的方法)
            Graphics g = Graphics.FromImage(image);
            //定义填充图图形
            System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.Blue, 1.2f, true);
            Brush brush1 = new SolidBrush(Color.Blue);
            Brush brush2 = new SolidBrush(Color.SaddleBrown);
            //定义画笔
            System.Drawing.Pen mypen = new Pen(brush, 1);
            System.Drawing.Pen mypen2 = new Pen(Color.Green, 2);
            System.Drawing.Pen mypen3 = new Pen(Color.Green, 1);
            Pen mypen4 = new Pen(Color.Green, 2);
            //定义字体
            Font font = new System.Drawing.Font("Arial", 9, FontStyle.Regular);
            Font font1 = new System.Drawing.Font("宋体", 20, FontStyle.Regular);
            Font font2 = new System.Drawing.Font("Arial", 8, FontStyle.Regular);
            //清空图片背景色
            g.Clear(Color.White);
            //创建点
            PointF center_Pt = new PointF(475, 225);//定义原点（中心点）
            float Xaxis_length = 405.0F;
            float Yaxis_length = 205.0F;
            PointF Xaxis_Begin = new PointF(center_Pt.X - Xaxis_length, center_Pt.Y);//X轴首端点
            PointF Xaxis_EndPt = new PointF(center_Pt.X - Xaxis_length, center_Pt.Y);//X轴末端点
            PointF Yaxis_Begin = new PointF(center_Pt.X, center_Pt.Y - Yaxis_length);//Y轴首端点
            PointF Yaxis_EndPt = new PointF(center_Pt.X, center_Pt.Y - Yaxis_length);//Y轴末端点
                                                                                     //①绘制由坐标对、宽度和高度指定的矩形(  x,  y, width, height)（绘制边框线）
            g.DrawRectangle(new Pen(Color.Black), Xaxis_Begin.X, Yaxis_EndPt.Y, 810, 410);
            //② 画X轴    画Y轴    （复杂方法）         
            // g.DrawLine(Pens.Black, Xaxis_Begin.X, Xaxis_Begin.Y, Xaxis_EndPt.X, Xaxis_EndPt.Y);//X轴首 末=左右
            // g.DrawLine(Pens.Black, Yaxis_Begin.X, Yaxis_Begin.Y, Yaxis_EndPt.X, Yaxis_EndPt.Y);//Y轴首 末=上下

            //画Y轴三角形箭头和单位
            PointF[] yPt = new PointF[3] { new PointF(Xaxis_Begin.X, Yaxis_EndPt.Y - 20), new PointF(Xaxis_Begin.X - 8, Yaxis_EndPt.Y), new PointF(Xaxis_Begin.X - 8, Yaxis_EndPt.Y) };//定位一个三角形有序对数组(位置)
            g.DrawPolygon(Pens.Black, yPt);//画三角形箭头
            g.FillPolygon(new SolidBrush(Color.Black), yPt);//填充成实心
            g.DrawString("Elec(°)", new Font("宋体", 12), Brushes.Black, new PointF(Xaxis_Begin.X - 70, Yaxis_EndPt.Y));//单位
                                                                                                                      //画X轴三角形箭头和单位
            PointF[] xPt = new PointF[3] { new PointF(Xaxis_EndPt.X - 20, Yaxis_Begin.Y), new PointF(Xaxis_EndPt.X, Yaxis_Begin.Y - 8), new PointF(Xaxis_EndPt.X, Yaxis_Begin.Y - 8) };//定位一个三角形有序对数组(位置)
            g.DrawPolygon(Pens.Black, xPt);//画三角形箭头
            g.FillPolygon(new SolidBrush(Color.Black), xPt);  //填充成实心
            g.DrawString("Angle(°)", new Font("宋体", 12), Brushes.Black, new PointF(Xaxis_EndPt.X - 15, Yaxis_Begin.Y - 20));//单位


            //添加背景颜色
            g.FillRectangle(Brushes.Lavender, Xaxis_Begin.X + 1, Yaxis_EndPt.Y + 1, width + 9, height + 59);

            //绘制线条
            //绘制纵向线条
            //x和y（430）为首个竖向线条的位置，13为竖向线条总数，60为竖向间隔
            float x = 140;
            for (int i = 0; i < 11; i++)
            {
                g.DrawLine(mypen, x, Yaxis_Begin.Y, x, Yaxis_EndPt.Y);
                x = x + 67;
            }
            //绘制横向线条
            //y和x（820）为首个横向线条的位置，7为横向线条总数，45为横向间隔
            float y = 75;
            for (int i = 0; i < 7; i++)
            {
                g.DrawLine(mypen, Xaxis_Begin.X, y, Xaxis_EndPt.X, y);
                y = y + 51;
            }
            //绘制一条虚线（标准线）
            mypen4.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            g.DrawLine(mypen4, new Point(70, 35), new Point(882, 35));

            //刻度
            //x轴上对应的标记
            String[] n = { " -180", " -150", " -120", " -90", " -60", " -30", "  0", " 30", " 60", " 90", "120", "150", "180" };
            //设置文字内容及输出位置（DrawString 在指定位置输出文本）
            //x和y（435）为首个刻度的位置，13为刻度总数，60为刻度间隔
            x = 50.0F;
            for (int i = 0; i < 13; i++)
            {
                g.DrawString(n[i].ToString(), font, Brushes.Red, x, 435);
                x = x + 68.5F;
            }
            //y轴上对应的标记
            String[] m = { "    0", " -10", " -20", " -30", " -40", " -50", " -60", " -70", " -80" };
            //设置文字内容及输出位置（DrawString 在指定位置输出文本）
            //x(70)和y为首个刻度的位置，13为刻度总数，60为刻度间隔
            y = 12.5F;
            for (int i = 0; i < 9; i++)
            {
                g.DrawString(m[i].ToString(), font, Brushes.Red, 40, y);
                y = y + 51.4F;
            }

            g.Dispose();

            return image;
        }
    }
}
