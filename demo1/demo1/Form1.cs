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

namespace demo1
{
    public partial class Form1 : Form
    {
        private LoadFile loadFile = new LoadFile();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            string path = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            textBox1.Text = path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = loadFile.Load(this.textBox1.Text);
        }
    }
}
