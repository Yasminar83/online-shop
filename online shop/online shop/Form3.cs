using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_shop
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string classification = textBox2.Text;
            string code = textBox3.Text;
            string product = name + '-' + classification + '-' + code + '\n';
            var fs = File.Create("pdata.csv");
            fs.Close();
            File.WriteAllText("pdata.csv", product);
            File.AppendAllText("pdata.csv", product);
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }
    }
}
