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
    public partial class RandomDithering : Form
    {
        public int K { get; set; }

        public RandomDithering()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Kstring = textBox1.Text;
           
            if (Kstring == "")
            {
                String message = "Please input value";
                var result = MessageBox.Show(message, "",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                return;
            }
            else
            {
                K = int.Parse(textBox1.Text);
                this.Close();
            }

        }
    }
}
