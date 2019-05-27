using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo1.BLL;
using demo1.UI;

namespace demo1
{
    public partial class Form1 : Form
    {
        private Deal deal = new Deal();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = deal.gatAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "")
            {
                MessageBox.Show("请选择高度范围");
                if (this.comboBox2.Text == "")
                {
                    MessageBox.Show("请选择时间范围");
                }
            }
            else
            {
                this.dataGridView1.DataSource = deal.getByNalt(this.comboBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CoordinateSystem coordinateSystem = new CoordinateSystem(this.comboBox1.Text);
            coordinateSystem.Show();
        }
    }
}
