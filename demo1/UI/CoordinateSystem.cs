﻿using System;
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
        public CoordinateSystem()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CoordinateSystem_Load(object sender, EventArgs e)
        {
            //通过设置pictureBox1为pictureBox2的父类，来实现box2对于box1的透明
            this.pictureBox2.Parent = pictureBox1;
            pictureBox1.BackColor = Color.Transparent;

            this.pictureBox1.Image = new BLL.Deal().getXY();
            //Console.WriteLine(Application.StartupPath + "\\Icons\\map.png");
            this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Icons\\map.png");
        }
    }
}
