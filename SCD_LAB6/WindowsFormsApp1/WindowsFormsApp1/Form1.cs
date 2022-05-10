using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_start.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ComboBox comboBox1 = new ComboBox();
            

            comboBox1.Location = new System.Drawing.Point(20, 60);
            comboBox1.Name = "comboBox1";
            btn_start.Enabled = true;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            txt_when_addmore_click.Visible = true;
            string tasbeeh = txt_when_addmore_click.Text;
            
            comboBox1.Items.Add(tasbeeh);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //numericUpDown1.
            //numericUpDown1.num
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
