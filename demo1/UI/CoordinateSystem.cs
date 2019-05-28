using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo1.DAL;

namespace demo1.UI
{
    public partial class CoordinateSystem : Form
    {

        private BLL.Deal deal = new BLL.Deal();
        int day = DateTime.Now.Day;

        public CoordinateSystem(string text, string text2)
        {
            InitializeComponent();
            this.label1.Text = text;
            this.label6.Text = text2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CoordinateSystem_Load(object sender, EventArgs e)
        {
            //通过设置pictureBox1为pictureBox2的父类，来实现box2对于box1的透明
            this.pictureBox2.Parent = pictureBox1;
            pictureBox1.BackColor = Color.Transparent;

            //通过设置pictureBox2为pictureBox3的父类，来实现box3对于box2的透明
            this.pictureBox3.Parent = pictureBox2;
            pictureBox2.BackColor = Color.Transparent;

            //设置box1图片
            //this.pictureBox1.Image = deal.getXY();
            this.pictureBox1.Image = deal.getXY2();

            //设置box2图片(局部放大地图)
            this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Icons\\map.png");
            //设置box2图片(完整地图)
            //this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Icons\\map2.png");

            //设置box3图片
            //this.pictureBox3.Image = deal.getPoints(label1.Text);
            //this.pictureBox3.Image = deal.getPointsT(label1.Text, label6.Text);
            //泛型设置box3图片
            switch (day)
            {
                case 1:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata01>(label1.Text, label6.Text);
                    break;
                case 2:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata02>(label1.Text, label6.Text);
                    break;
                case 3:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata03>(label1.Text, label6.Text);
                    break;
                case 4:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata04>(label1.Text, label6.Text);
                    break;
                case 5:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata05>(label1.Text, label6.Text);
                    break;
                case 6:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata06>(label1.Text, label6.Text);
                    break;
                case 7:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata07>(label1.Text, label6.Text);
                    break;
                case 8:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata08>(label1.Text, label6.Text);
                    break;
                case 9:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata09>(label1.Text, label6.Text);
                    break;
                case 10:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata10>(label1.Text, label6.Text);
                    break;
                case 11:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata11>(label1.Text, label6.Text);
                    break;
                case 12:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata12>(label1.Text, label6.Text);
                    break;
                case 13:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata13>(label1.Text, label6.Text);
                    break;
                case 14:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata14>(label1.Text, label6.Text);
                    break;
                case 15:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata15>(label1.Text, label6.Text);
                    break;
                case 16:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata16>(label1.Text, label6.Text);
                    break;
                case 17:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata17>(label1.Text, label6.Text);
                    break;
                case 18:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata18>(label1.Text, label6.Text);
                    break;
                case 19:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata19>(label1.Text, label6.Text);
                    break;
                case 20:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata20>(label1.Text, label6.Text);
                    break;
                case 21:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata21>(label1.Text, label6.Text);
                    break;
                case 22:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata22>(label1.Text, label6.Text);
                    break;
                case 23:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata23>(label1.Text, label6.Text);
                    break;
                case 24:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata24>(label1.Text, label6.Text);
                    break;
                case 25:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata25>(label1.Text, label6.Text);
                    break;
                case 26:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata26>(label1.Text, label6.Text);
                    break;
                case 27:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata27>(label1.Text, label6.Text);
                    break;
                case 28:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata28>(label1.Text, label6.Text);
                    break;
                case 29:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata29>(label1.Text, label6.Text);
                    break;
                case 30:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata30>(label1.Text, label6.Text);
                    break;
                case 31:
                    this.pictureBox3.Image = deal.getPointsT<nacarsdata31>(label1.Text, label6.Text);
                    break;
            }

            //将DrawPoint()中的PictureBox列表循环添加到窗体中
            //List<PictureBox> picBoxList = deal.getPictures(label1.Text);
            //List<PictureBox> picBoxList = deal.getPicturesT(label1.Text, label6.Text);
            //泛型设置
            List<PictureBox> picBoxList;
            switch (day)
            {
                case 1:
                    picBoxList = deal.getPicturesT<nacarsdata01>(label1.Text, label6.Text);
                    break;
                case 2:
                    picBoxList = deal.getPicturesT<nacarsdata02>(label1.Text, label6.Text);
                    break;
                case 3:
                    picBoxList = deal.getPicturesT<nacarsdata03>(label1.Text, label6.Text);
                    break;
                case 4:
                    picBoxList = deal.getPicturesT<nacarsdata04>(label1.Text, label6.Text);
                    break;
                case 5:
                    picBoxList = deal.getPicturesT<nacarsdata05>(label1.Text, label6.Text);
                    break;
                case 6:
                    picBoxList = deal.getPicturesT<nacarsdata06>(label1.Text, label6.Text);
                    break;
                case 7:
                    picBoxList = deal.getPicturesT<nacarsdata07>(label1.Text, label6.Text);
                    break;
                case 8:
                    picBoxList = deal.getPicturesT<nacarsdata08>(label1.Text, label6.Text);
                    break;
                case 9:
                    picBoxList = deal.getPicturesT<nacarsdata09>(label1.Text, label6.Text);
                    break;
                case 10:
                    picBoxList = deal.getPicturesT<nacarsdata10>(label1.Text, label6.Text);
                    break;
                case 11:
                    picBoxList = deal.getPicturesT<nacarsdata11>(label1.Text, label6.Text);
                    break;
                case 12:
                    picBoxList = deal.getPicturesT<nacarsdata12>(label1.Text, label6.Text);
                    break;
                case 13:
                    picBoxList = deal.getPicturesT<nacarsdata13>(label1.Text, label6.Text);
                    break;
                case 14:
                    picBoxList = deal.getPicturesT<nacarsdata14>(label1.Text, label6.Text);
                    break;
                case 15:
                    picBoxList = deal.getPicturesT<nacarsdata15>(label1.Text, label6.Text);
                    break;
                case 16:
                    picBoxList = deal.getPicturesT<nacarsdata16>(label1.Text, label6.Text);
                    break;
                case 17:
                    picBoxList = deal.getPicturesT<nacarsdata17>(label1.Text, label6.Text);
                    break;
                case 18:
                    picBoxList = deal.getPicturesT<nacarsdata18>(label1.Text, label6.Text);
                    break;
                case 19:
                    picBoxList = deal.getPicturesT<nacarsdata19>(label1.Text, label6.Text);
                    break;
                case 20:
                    picBoxList = deal.getPicturesT<nacarsdata20>(label1.Text, label6.Text);
                    break;
                case 21:
                    picBoxList = deal.getPicturesT<nacarsdata21>(label1.Text, label6.Text);
                    break;
                case 22:
                    picBoxList = deal.getPicturesT<nacarsdata22>(label1.Text, label6.Text);
                    break;
                case 23:
                    picBoxList = deal.getPicturesT<nacarsdata23>(label1.Text, label6.Text);
                    break;
                case 24:
                    picBoxList = deal.getPicturesT<nacarsdata24>(label1.Text, label6.Text);
                    break;
                case 25:
                    picBoxList = deal.getPicturesT<nacarsdata25>(label1.Text, label6.Text);
                    break;
                case 26:
                    picBoxList = deal.getPicturesT<nacarsdata26>(label1.Text, label6.Text);
                    break;
                case 27:
                    picBoxList = deal.getPicturesT<nacarsdata27>(label1.Text, label6.Text);
                    break;
                case 28:
                    picBoxList = deal.getPicturesT<nacarsdata28>(label1.Text, label6.Text);
                    break;
                case 29:
                    picBoxList = deal.getPicturesT<nacarsdata29>(label1.Text, label6.Text);
                    break;
                case 30:
                    picBoxList = deal.getPicturesT<nacarsdata30>(label1.Text, label6.Text);
                    break;
                case 31:
                    picBoxList = deal.getPicturesT<nacarsdata31>(label1.Text, label6.Text);
                    break;
                default:
                    picBoxList = deal.getPicturesT<nacarsdata01>(label1.Text, label6.Text);
                    break;
            }

            for (int i = 0; i < picBoxList.Count; i++)
            {
                this.Controls.Add(picBoxList[i]);
                picBoxList[i].BringToFront();
            }

            //左下角标识
            this.label3.Text = label1.Text;
            this.label5.Text = DateTime.Now.ToShortDateString();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
