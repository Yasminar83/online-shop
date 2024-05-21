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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string family = textBox2.Text;
            string phone = textBox3.Text;
            string costumers = name + '-' + family + '-' + phone + '\n';
            var fs = File.Create("cdata.csv");
            fs.Close();
            File.AppendAllText("cdata.csv", costumers);
            fs.Close();
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }
    }
}
