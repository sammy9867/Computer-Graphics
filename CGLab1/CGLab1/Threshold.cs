using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGLab1
{
    public partial class Threshold : Form
    {
        public int M { get; set; }
        public double T { get; set; }

        public Threshold()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string Mstring = textBox1.Text;
            string Tstring = textBox2.Text;
            if (Mstring == "" || Tstring == "")
            {
                String message = "Please input value";
                var result = MessageBox.Show(message, "",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                return;
            }
            else
            {
                M = int.Parse(textBox1.Text);
                T = double.Parse(textBox2.Text);
                this.Close();
            }
        }
    }
}
