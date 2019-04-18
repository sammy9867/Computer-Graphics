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
    public partial class GammaSetterr : Form
    {
        public double gamma { get; set; }

        public GammaSetterr()
        {
            InitializeComponent();
            gamma = 0;
        }

        private void gammaButton_Click(object sender, EventArgs e)
        {
            string gammaString = gammaText.Text;
            if (gammaString == "")
            {
                String message = "Please input a gamma exponent value";
                var result = MessageBox.Show(message, "",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                return;
            }
            else
            {
                gamma = double.Parse(gammaText.Text);
                  this.Close();
            }
          
        }

      
    }
}
