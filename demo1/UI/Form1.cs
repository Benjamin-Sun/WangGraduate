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
using demo1.DAL;

namespace demo1
{
    public partial class Form1 : Form
    {
        private Deal deal = new Deal();
        int day = DateTime.Now.Day;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //基本查询
            this.dataGridView1.DataSource = deal.getAll();
            
            //根据日期查询相对应的表
            switch (day)
            {
                case 1:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata01>();
                    break;
                case 2:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata02>();
                    break;
                case 3:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata03>();
                    break;
                case 4:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata04>();
                    break;
                case 5:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata05>();
                    break;
                case 6:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata06>();
                    break;
                case 7:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata07>();
                    break;
                case 8:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata08>();
                    break;
                case 9:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata09>();
                    break;
                case 10:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata10>();
                    break;
                case 11:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata11>();
                    break;
                case 12:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata12>();
                    break;
                case 13:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata13>();
                    break;
                case 14:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata14>();
                    break;
                case 15:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata15>();
                    break;
                case 16:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata16>();
                    break;
                case 17:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata17>();
                    break;
                case 18:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata18>();
                    break;
                case 19:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata19>();
                    break;
                case 20:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata20>();
                    break;
                case 21:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata21>();
                    break;
                case 22:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata22>();
                    break;
                case 23:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata23>();
                    break;
                case 24:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata24>();
                    break;
                case 25:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata25>();
                    break;
                case 26:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata26>();
                    break;
                case 27:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata27>();
                    break;
                case 28:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata28>();
                    break;
                case 29:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata31>();
                    break;
                case 30:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata30>();
                    break;
                case 31:
                    this.dataGridView1.DataSource = deal.getAll<nacarsdata31>();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.Text == "")
            {
                MessageBox.Show("请选择时间范围");
            }
            if (this.comboBox1.Text == "")
            {
                MessageBox.Show("请选择高度范围");
            }
            else
            {
                //基本查询
                //this.dataGridView1.DataSource = deal.getByNaltAndTime(this.comboBox1.Text, this.comboBox2.Text);

                //根据日期查询相对应的表
                switch (day)
                {
                    case 1:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata01>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 2:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata02>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 3:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata03>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 4:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata04>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 5:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata05>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 6:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata06>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 7:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata07>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 8:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata08>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 9:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata09>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 10:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata10>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 11:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata11>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 12:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata12>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 13:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata13>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 14:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata14>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 15:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata15>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 16:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata16>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 17:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata17>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 18:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata18>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 19:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata19>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 20:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata20>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 21:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata21>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 22:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata22>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 23:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata23>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 24:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata24>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 25:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata25>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 26:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata26>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 27:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata27>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 28:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata28>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 29:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata31>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 30:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata30>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                    case 31:
                        this.dataGridView1.DataSource = deal.getByNaltAndTime<nacarsdata31>(this.comboBox1.Text, this.comboBox2.Text);
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CoordinateSystem coordinateSystem = new CoordinateSystem(this.comboBox1.Text, this.comboBox2.Text);
            //测试
            //CoordinateSystem coordinateSystem = new CoordinateSystem("FL180", "6小时内");
            coordinateSystem.Show();
        }
    }
}
