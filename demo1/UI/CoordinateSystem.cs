using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo1.UI
{
    public partial class CoordinateSystem : Form
    {

        private BLL.Deal deal = new BLL.Deal();

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
            this.pictureBox1.Image = deal.getXY();
            //Console.WriteLine(Application.StartupPath + "\\Icons\\map.png");
            //设置box2图片
            this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Icons\\map.png");
            //设置box3图片
            this.pictureBox3.Image = deal.getPoints(label1.Text);

            //将DrawPoint()中的PictureBox列表循环添加到窗体中
            List<PictureBox> picBoxList = deal.getPictures(label1.Text);
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
