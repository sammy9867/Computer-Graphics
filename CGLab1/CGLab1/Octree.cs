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
    public partial class Octree : Form
    {
        public int availableColors { get; set; }

        public Octree()
        {
            InitializeComponent();
            availableColors = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string availColorsString = textBox1.Text;
            if (availColorsString == "")
            {
                String message = "Please input a value in the range: [1, 1024]";
                var result = MessageBox.Show(message, "",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                return;
            }
            else if (int.Parse(textBox1.Text) < 1 || int.Parse(textBox1.Text) > 1024)
            {


                String message = "Please input a value in the range: [1, 1024]";
                var result = MessageBox.Show(message, "",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                return;

            }
            else
            {
                availableColors = int.Parse(textBox1.Text);
                this.Close();
            }
        }
    }
}
