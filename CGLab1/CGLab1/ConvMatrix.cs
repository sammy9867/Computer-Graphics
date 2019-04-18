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
    public partial class ConvMatrix : Form
    {
        public double[,] _matrix { get; set; }
        public int rows { get; set; }
        public int columns { get; set; }

        public int divisor { get; set; }
        public int offset { get; set; }
        public int anchor_row { get; set; }
        public int anchor_col { get; set; }

        public ConvMatrix()
        {
            InitializeComponent();

            anchor_row = 0;
            anchor_col = 0;
            rows = columns = 0;
            divisor = 0;
            offset = 0;

           _matrix = new double[rows, columns];
        }

        private void addNewRowsAndColumns(double[,] Matrix)
        {
            divisor = 0;
            offset = 0;

            int x = 9, y = 13;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new Point(x, y);
                    textBox.Size = new Size(50, 22);
                    textBox.Text = Matrix[i, j].ToString();
                    divisor += (int)Matrix[i, j];

                    textBox.Tag = i + "x" + j;
                    panel2.Controls.Add(textBox);

                  
                    y += 28;
                }
                x += 60;
                y = 13;
            }

            if (divisor == 0) divisor = 1;
            textBox3.Text = divisor.ToString();

        }

        //Validation
        private void validate()
        {
            string rowString = textBox1.Text;
            string columnString = textBox2.Text;
            if (rowString == "" || columnString == "")
            {
                String message = "Please input matrix range between 1 and 9 inclusive";
                var result = MessageBox.Show(message, "",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                return;

            }
            for (int i = 0; i < rowString.Length; i++)
            {
                if (!char.IsNumber(rowString[i]))
                {
                    textBox1.Text = "";
                    return;
                }
            }

            for (int i = 0; i < columnString.Length; i++)
            {
                if (!char.IsNumber(columnString[i]))
                {

                    textBox2.Text = "";
                    return;
                }
            }

            rows = int.Parse(rowString);
            columns = int.Parse(columnString);
        }

        //Generate Matrix
        private void generate_Click(object sender, EventArgs e)
        {

            string rowString = textBox1.Text;
            string columnString = textBox2.Text;
            if (rowString == "" || columnString == "")
            {
                String message = "Please input matrix range between 1 and 9 inclusive";
                var result = MessageBox.Show(message, "",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                return;

            }
            for (int i = 0; i < rowString.Length; i++)
            {
                if (!char.IsNumber(rowString[i]))
                {
                    textBox1.Text = "";
                    return;
                }
            }

            for (int i = 0; i < columnString.Length; i++)
            {
                if (!char.IsNumber(columnString[i]))
                {

                    textBox2.Text = "";
                    return;
                }
            }

            rows = int.Parse(rowString);
            columns = int.Parse(columnString);

            if (rows < 1 || rows > 9 || columns < 0 || columns > 9)
            {
                String message = "Please input matrix range between 1 and 9 inclusive";
                var result = MessageBox.Show(message, "",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
            }
            else
            {
                panel2.Controls.Clear();
                _matrix = new double[rows, columns];
                addNewRowsAndColumns(_matrix);
                
            }
        }


        //Apply Changes
        private void apply_Click(object sender, EventArgs e)
        {
            divisor = int.Parse(textBox3.Text);
            offset = int.Parse(textBox4.Text);

            anchor_row = int.Parse(textBox5.Text);
            anchor_col = int.Parse(textBox6.Text);

            validate();
        

            int _matrix_size = 0;
            int _center;
            _center = _matrix_size = Math.Max(Math.Max(anchor_row, anchor_col) ,Math.Max(rows-1 - anchor_row, columns-1 - anchor_col) );
            _matrix_size *= 2;
            _matrix_size += 1;
            _matrix = new double[_matrix_size, _matrix_size];

            int deltaX = _center - anchor_col;
            int deltaY = _center - anchor_row;

            foreach (Control control in panel2.Controls)
            {
                if (control is TextBox)
                {
                    int i, j;
                    string[] coor = new string[2];
                    coor = control.Tag.ToString().Split('x');
                    i = Int16.Parse(coor[0]);
                    j = Int16.Parse(coor[1]);

                    _matrix[i+deltaY, j+deltaX] = Int32.Parse(control.Text.ToString());

                }
            }


            this.Close();
        }

        #region Predefined ConvolutionFilters
        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            _matrix = new double[3, 3] { {1, 1, 1},
                {1, 1, 1},
                {1, 1, 1} };
            textBox1.Text = "3";
            textBox2.Text = "3";
            textBox5.Text = "1";
            textBox6.Text = "1";
            rows = 3;
            columns = 3;
            anchor_row = 1;
            anchor_col = 1;
            addNewRowsAndColumns(_matrix);


        }

        private void gausToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            _matrix = new double[3, 3] { {0, 1, 0},
            {1, 4, 1},
            {0, 1, 0} };
            textBox1.Text = "3";
            textBox2.Text = "3";
            textBox5.Text = "1";
            textBox6.Text = "1";
            rows = 3;
            columns = 3;
            anchor_row = 1;
            anchor_col = 1;
            addNewRowsAndColumns(_matrix);
        }

        private void sharpenFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            _matrix = new double[3, 3] { {0, -1, 0},
           {-1, 5, -1},
           {0, -1, 0} };
            textBox1.Text = "3";
            textBox2.Text = "3";
            textBox5.Text = "1";
            textBox6.Text = "1";
            rows = 3;
            columns = 3;
            anchor_row = 1;
            anchor_col = 1;
            addNewRowsAndColumns(_matrix);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            _matrix = new double[3, 3] {   {0, -1, 0},
            {0, 1, 0},
            {0, 0, 0} };
            textBox1.Text = "3";
            textBox2.Text = "3";
            textBox5.Text = "1";
            textBox6.Text = "1";
            rows = 3;
            columns = 3;
            anchor_row = 1;
            anchor_col = 1;
            addNewRowsAndColumns(_matrix);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            _matrix = new double[3, 3] {  {0, 0, 0},
           {-1, 1, 0},
           {0, 0, 0} };
            textBox1.Text = "3";
            textBox2.Text = "3";
            textBox5.Text = "1";
            textBox6.Text = "1";
            rows = 3;
            columns = 3;
            anchor_row = 1;
            anchor_col = 1;
            addNewRowsAndColumns(_matrix);
        }

        private void diagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            _matrix = new double[3, 3] { { -1, 0, 0 },
           { 0, 1, 0 },
           { 0, 0, 0 } };
            textBox1.Text = "3";
            textBox2.Text = "3";
            textBox5.Text = "1";
            textBox6.Text = "1";
            rows = 3;
            columns = 3;
            anchor_row = 1;
            anchor_col = 1;
            addNewRowsAndColumns(_matrix);
        }

        private void northToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            _matrix = new double[3, 3] { {1, 1, 1},
         {0, 0, 0},
         {-1, -1, -1} };
            textBox1.Text = "3";
            textBox2.Text = "3";
            textBox5.Text = "1";
            textBox6.Text = "1";
            rows = 3;
            columns = 3;
            anchor_row = 1;
            anchor_col = 1;
            addNewRowsAndColumns(_matrix);
        }

        private void southToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            _matrix = new double[3, 3] {   {-1, -1, -1},
           {0, 0, 0},
           {1, 1, 1} };
            textBox1.Text = "3";
            textBox2.Text = "3";
            textBox5.Text = "1";
            textBox6.Text = "1";
            rows = 3;
            columns = 3;
            anchor_row = 1;
            anchor_col = 1;
            addNewRowsAndColumns(_matrix);
        }

        private void eastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            _matrix = new double[3, 3] {  {-1, 0, 1},
          {-1, 0, 1},
          {-1, 0, 1} };
            textBox1.Text = "3";
            textBox2.Text = "3";
            textBox5.Text = "1";
            textBox6.Text = "1";
            rows = 3;
            columns = 3;
            anchor_row = 1;
            anchor_col = 1;
            addNewRowsAndColumns(_matrix);
        }

        private void westToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            _matrix = new double[3, 3] { {1, 0, -1},
          {1, 0, -1},
          {1, 0, -1} };
            textBox1.Text = "3";
            textBox2.Text = "3";
            textBox5.Text = "1";
            textBox6.Text = "1";
            rows = 3;
            columns = 3;
            anchor_row = 1;
            anchor_col = 1;
            addNewRowsAndColumns(_matrix);
        }

        private void southEastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            _matrix = new double[3, 3] { {-1, -1, 0},
          {-1, 1, 1},
          {0, 1, 1} };
            textBox1.Text = "3";
            textBox2.Text = "3";
            textBox5.Text = "1";
            textBox6.Text = "1";
            rows = 3;
            columns = 3;
            anchor_row = 1;
            anchor_col = 1;
            addNewRowsAndColumns(_matrix);
        }





        #endregion

      
    }
}
