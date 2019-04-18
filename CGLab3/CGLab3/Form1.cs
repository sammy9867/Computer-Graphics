using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGLab3
{
    public partial class Drawing : Form
    {
        private Bitmap draw;
        private Color color;

        private int x1, x2;
        private int y1, y2;

        private int thickness;

        private bool midpointLine;
        private bool alternateMidpointCircle;
        private bool xwLine;
        private bool xwCircle;

        public Drawing()
        {
            int seed = 1;
            Random r = new Random(seed);
            color = Color.Black;
            InitializeComponent();

            x1 = x2 = y1 = y2 = -1;
           
            thickness = 1;
            thicknessLabel.Text = "Thickness: " + thickness;

            midpointLine = true;
            alternateMidpointCircle = xwLine = xwCircle = false;

            modeLabel.Text = "Midpoint\nLine";

            pictureSizeLabel.Text = "" + drawPictureBox.Width + "x" + drawPictureBox.Height;
        }

        #region PictureBox Click

        private void drawPictureBox_Click(object sender, EventArgs e)
        {
            int x = ((MouseEventArgs)e).X;
            int y = ((MouseEventArgs)e).Y;
            xLabel.Text = "x: " + x;
            yLabel.Text = "y: " + y;
            int xw = draw.Width;
            int yw = draw.Height;

            pictureSizeLabel.Text = "" + xw + "x" + yw;

            if (x1 == -1 || y1 == -1)
            {
                x1 = x; y1 = y;
            }
            else
            {
                x2 = x; y2 = y;
                if (midpointLine)
                    Midpoint_Line(x1, drawPictureBox.Height - y1, x2, drawPictureBox.Height - y2);
                else if (alternateMidpointCircle)
                    Alternate_Midpoint_Circle(x1, drawPictureBox.Height - y1, x2, drawPictureBox.Height - y2);
                else if (xwLine)
                    Xiaolin_Wu_Line(x1, drawPictureBox.Height - y1, x2, drawPictureBox.Height - y2);
                else if (xwCircle)
                    Xiaolin_Wu_Circle(x1, drawPictureBox.Height - y1, x2, drawPictureBox.Height - y2);
  

                x1 = x2 = y1 = y2 = -1;
            }
            drawPictureBox.Image = draw;

        }
        #endregion

        #region MenuStrips
        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            midpointLine = true;
            alternateMidpointCircle = xwLine = xwCircle = false;
            modeLabel.Text = "Midpoint\nLine";
        }

        private void midpointCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alternateMidpointCircle = true;
            midpointLine = xwLine = xwCircle = false;
            modeLabel.Text = "Alt. Midpoint\nCircle";
        }

        private void lineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            xwLine = true;
            alternateMidpointCircle = midpointLine = xwCircle = false;
            modeLabel.Text = "Xiaolin Wu\nLine";
        }


        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xwCircle = true;
            alternateMidpointCircle = midpointLine = xwLine = false;
            modeLabel.Text = "Xiaolin Wu\nCircle";
        }

        
        #endregion

        #region Midpoint Line

        private void Midpoint_Line(int x1, int y1, int x2, int y2)
        {
            float dx = x2 - x1;
            float dy = y2 - y1;

            int sx = (dx >= 0) ? 1 : (-1);
            int sy = (dy >= 0) ? 1 : (-1);

            int x = x1;
            int y = y1;

            int isSwaped = 0;

            // Swap if needed
            if (Math.Abs(dy) > Math.Abs(dx))
            {
                float tdx = dx;
                dx = dy;
                dy = tdx;

                isSwaped = 1;
            }

            float d = 2 * (Math.Abs(dy)) - Math.Abs(dx);
            putPixel(x, y);

            for (int i = 0; i <= Math.Abs(dx); i++)
            {
                if (d < 0) //move to E
                {
                    if (isSwaped == 0)
                    {
                        x = x + sx;

                        putPixel(x, y);

                    }
                    else
                    {
                        y = y + sy;
                        putPixel(x, y);
                    }
                    d = d + 2 * Math.Abs(dy);
                }
                else //move to NE
                {
                    x = x + sx;
                    y = y + sy;
                    putPixel(x, y);
                    d = d + 2 * Math.Abs(dy) - 2 * Math.Abs(dx);
                }
            }
        }

        #endregion

        #region Alternate Midpoint Circle    
        private void Alternate_Midpoint_Circle(int x1, int y1, int x2, int y2)
        {
            int dx = (int)Math.Abs(x2 - x1);
            int dy = (int)Math.Abs(y2 - y1);
            int R = (int)Math.Sqrt(dx * dx + dy * dy);
          
            int dE = 3;
            int dSE = 5 - 2 * R;

            int d = 1 - R;
            int x = 0; 
            int y = R; 

         
            putPixel(x1 + x, y1 + y);
            putPixel(x1 + y, y1 + x);
            putPixel(x1 - y, y1 + x);
            putPixel(x1 - x, y1 + y);
            putPixel(x1 - x, y1 - y);
            putPixel(x1 - y, y1 - x);
            putPixel(x1 + y, y1 - x);
            putPixel(x1 + x, y1 - y);

            while (y > x)
            {
                if (d < 0) //move to E
                { 

                    d += dE;
                    dE += 2;
                    dSE += 2;

                }
                else //move to SE
                {
                    d += dSE;
                    dE += 2;
                    dSE += 4;
                    --y;
                }
                ++x;
         
                putPixel(x1 + x, y1 + y);
                putPixel(x1 + y, y1 + x);
                putPixel(x1 - y, y1 + x);
                putPixel(x1 - x, y1 + y);
                putPixel(x1 - x, y1 - y);
                putPixel(x1 - y, y1 - x);
                putPixel(x1 + y, y1 - x);
                putPixel(x1 + x, y1 - y);

            }

        }
        #endregion

        #region Xiaolin Wu
        private void Xiaolin_Wu_Line(int x1, int y1, int x2, int y2)
        {
            int old_thickness = thickness;
            thickness = 1;
            Color backcolor = Color.FromArgb(color.R + 175 > 255 ? 255 : color.R + 175,
                                             color.G + 175 > 255 ? 255 : color.G + 175,
                                             color.B + 175 > 255 ? 255 : color.B + 175);
            float dy = y2 - y1, dx = x2 - x1;
            float m = dy / dx;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                if (x1 > x2)
                {
                    int tmp = x1; x1 = x2; x2 = tmp;
                    tmp = y1; y1 = y2; y2 = tmp;
                }
                float y = y1;
                for (int x = x1; x <= x2; ++x)
                {
                    Color c1 = Color.FromArgb((byte)(color.R * (1 - (y - (int)y)) + backcolor.R * (y - (int)y)),
                                              (byte)(color.G * (1 - (y - (int)y)) + backcolor.G * (y - (int)y)),
                                              (byte)(color.B * (1 - (y - (int)y)) + backcolor.B * (y - (int)y)));
                    Color c2 = Color.FromArgb((byte)(color.R * ((y - (int)y)) + backcolor.R * (1 - (y - (int)y))),
                                              (byte)(color.G * ((y - (int)y)) + backcolor.G * (1 - (y - (int)y))),
                                              (byte)(color.B * ((y - (int)y)) + backcolor.B * (1 - (y - (int)y))));

                    if (c1.R + c1.G + c1.B > c2.R + c2.G + c2.B)
                    {
                        putPixel(x, (int)Math.Floor(y), c1);
                        putPixel(x, (int)Math.Floor(y) + 1, c2);
                    }
                    else
                    {
                        putPixel(x, (int)Math.Floor(y) + 1, c2);
                        putPixel(x, (int)Math.Floor(y), c1);
                    }
                    y += m;
                    drawPictureBox.Image = draw;
                }
            }
            else
            {
                if (y1 > y2)
                {
                    int tmp = x1; x1 = x2; x2 = tmp;
                    tmp = y1; y1 = y2; y2 = tmp;
                }
                float x = x1;
                m = dx / dy;
                for (int y = y1; y < y2; ++y)
                {
                    Color c1 = Color.FromArgb((byte)(color.R * (1 - (x - (int)x)) + backcolor.R * (x - (int)x)),
                                              (byte)(color.G * (1 - (x - (int)x)) + backcolor.G * (x - (int)x)),
                                              (byte)(color.B * (1 - (x - (int)x)) + backcolor.B * (x - (int)x)));
                    Color c2 = Color.FromArgb((byte)(color.R * ((x - (int)x)) + backcolor.R * (1 - (x - (int)x))),
                                              (byte)(color.G * ((x - (int)x)) + backcolor.G * (1 - (x - (int)x))),
                                              (byte)(color.B * ((x - (int)x)) + backcolor.B * (1 - (x - (int)x))));
                    if (c1.R + c1.G + c1.B > c2.R + c2.G + c2.B)
                    {
                        putPixel((int)Math.Floor(x), y, c1);
                        putPixel((int)Math.Floor(x) + 1, y, c2);
                    }
                    else
                    {
                        putPixel((int)Math.Floor(x) + 1, y, c2);
                        putPixel((int)Math.Floor(x), y, c1);
                    }
                    x += m; 
                }
            }
            thickness = old_thickness;
        }

        private void Xiaolin_Wu_Circle(int x1, int y1, int x2, int y2)
        {
            int old_thickness = thickness;
            thickness = 1;

            Color backcolor = Color.FromArgb(color.R + 100 > 175 ? 175 : color.R + 100,
                                              color.G + 100 > 175 ? 175 : color.G + 100,
                                              color.B + 100 > 175 ? 175 : color.B + 100);
            int dx = (int)Math.Abs(x2 - x1);
            int dy = (int)Math.Abs(y2 - y1);
            int R = (int)Math.Sqrt(dx * dx + dy * dy);

            double x = R;
            int y = 0;

            float T = D(R, y);
            Color c1 = Color.FromArgb((byte)(color.R * (1 - T) + backcolor.R * T),
                                      (byte)(color.G * (1 - T) + backcolor.G * T),
                                      (byte)(color.B * (1 - T) + backcolor.B * T));
            Color c2 = Color.FromArgb((byte)(color.R * (T) + backcolor.R * (1 - T)),
                                      (byte)(color.G * (T) + backcolor.G * (1 - T)),
                                      (byte)(color.B * (T) + backcolor.B * (1 - T)));

            putPixel(x1 + (int)x, y1 + y, c1);
            putPixel(x1 - y, y1 + (int)x, c1);
            putPixel(x1 - (int)x, y1 - y, c1);
            putPixel(x1 + y, y1 - (int)x, c1);

            for (y = 0; y < (int)x; y++)
            {
                T = D(R, y);
                c2 = Color.FromArgb((byte)(color.R * (1 - T) + backcolor.R * T),
                                    (byte)(color.G * (1 - T) + backcolor.G * T),
                                    (byte)(color.B * (1 - T) + backcolor.B * T));
                c1 = Color.FromArgb((byte)(color.R * (T) + backcolor.R * (1 - T)),
                                    (byte)(color.G * (T) + backcolor.G * (1 - T)),
                                    (byte)(color.B * (T) + backcolor.B * (1 - T)));

                x = Math.Sqrt(R * R - y * y);
                int f = (int)x % 1;
                int xleft = (int)(x - f);

                /* * *  I Octant * * */
                putPixel(x1 + xleft, y1 + y, c1);
                putPixel(x1 + xleft + 1, y1 + y, c2);
                /* * * II Octant * * */
                putPixel(x1 + y, y1 + xleft, c1);
                putPixel(x1 + y, y1 + xleft + 1, c2);
                /* * * III Octant * * */
                putPixel(x1 - y, y1 + xleft, c1);
                putPixel(x1 - y, y1 + xleft + 1, c2);
                /* * * IV Octant * * */
                putPixel(x1 - xleft, y1 + y, c1);
                putPixel(x1 - xleft + 1, y1 + y, c2);
                /* * *  V Octant * * */
                putPixel(x1 - xleft, y1 - y, c1);
                putPixel(x1 - xleft + 1, y1 - y, c2);
                /* * * VI Octant * * */
                putPixel(x1 - y, y1 - xleft, c1);
                putPixel(x1 - y, y1 - xleft + 1, c2);
                /* * * VII Octant * * */
                putPixel(x1 + y, y1 - xleft, c1);
                putPixel(x1 + y, y1 - xleft + 1, c2);
                /* * * VIII Octant * * */
                putPixel(x1 + xleft, y1 - y, c1);
                putPixel(x1 + xleft + 1, y1 - y, c2);
            }
            thickness = old_thickness;
        }

        private float D(int R, int y)
        {
            float x = (float)Math.Sqrt(R * R - y * y);
            return (float)Math.Ceiling(x) - x;
        }
        #endregion

        #region Thickness
        private void increaseThicknessButton_Click(object sender, EventArgs e)
        {
            thickness += 1;
            if (thickness > 3) thickness = 3;
            thicknessLabel.Text = "Thickness: " + thickness;
           
           
        }

        private void decreaseThicknessButton_Click(object sender, EventArgs e)
        {
            thickness -= 1;
            if (thickness < 1) thickness = 1;
            thicknessLabel.Text = "Thickness: " + thickness;
  
        }
        #endregion
 
        #region Load

        private void Drawing_Load(object sender, EventArgs e)
        {
            draw = new Bitmap(drawPictureBox.Width, drawPictureBox.Height);
            drawPictureBox.Image = draw;
        }

        #endregion

        #region Clear
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < draw.Height; i++)
                for (int j = 0; j < draw.Width; j++)
                    draw.SetPixel(j, i, Color.White);

            drawPictureBox.Image = draw;
        }



        #endregion

        #region putPixel      
        private void putPixel(int x, int y)
        {

            if (x < 0) x = 0;
            if (x >= draw.Width) x = draw.Width - 1;
            if (y < 0) y = 0;
            if (y >= draw.Height) y = draw.Height - 1;

            if(thickness == 1)
            draw.SetPixel(x, draw.Height - 1 - y, color);

            if (thickness == 2)
            {
                if (draw.Height - 1 - y + 1 < draw.Height)
                    draw.SetPixel(x, draw.Height - 1 - y + 1, color); // up
                if (draw.Height - 1 - y - 1 >= 0)
                    draw.SetPixel(x, draw.Height - 1 - y - 1, color); //down
                if (x - 1 >= 0)
                    draw.SetPixel(x - 1, draw.Height - 1 - y, color);  //left
                if (x + 1 < draw.Width)
                    draw.SetPixel(x + 1, draw.Height - 1 - y, color);  //right
            }

            if (thickness == 3)
            {
                if (draw.Height - 1 - y + 2 < draw.Height)
                    draw.SetPixel(x, draw.Height - 1 - y + 2, color); // up2
                if (draw.Height - 1 - y - 2 >= 0)
                    draw.SetPixel(x, draw.Height - 1 - y - 2, color); //down2
                if (draw.Height - 1 - y + 1 < draw.Height && x - 1 >= 0)
                    draw.SetPixel(x - 1, draw.Height - 1 - y + 1, color); // up left
                if (draw.Height - 1 - y + 1 < draw.Height && x + 1 < draw.Width)
                    draw.SetPixel(x + 1, draw.Height - 1 - y + 1, color); // up right
                if (x - 2 >= 0)
                    draw.SetPixel(x - 2, draw.Height - 1 - y, color);  //left2
                if (x + 2 < draw.Width)
                    draw.SetPixel(x + 2, draw.Height - 1 - y, color);  //right2
                if (draw.Height - 1 - y - 1 >= 0 && x - 1 >= 0)
                    draw.SetPixel(x - 1, draw.Height - 1 - y - 1, color); //down left
                if (draw.Height - 1 - y - 1 >= 0 && x + 1 < draw.Width)
                    draw.SetPixel(x + 1, draw.Height - 1 - y - 1, color);  //down right
            }

        }

     

        private void putPixel(int x, int y, Color color)
        {

            if (x < 0) x = 0;
            if (x >= draw.Width) x = draw.Width - 1;
            if (y < 0) y = 0;
            if (y >= draw.Height) y = draw.Height - 1;

            if (thickness == 1)
                draw.SetPixel(x, draw.Height - 1 - y, color);

            if (thickness == 2)
            {
                if (draw.Height - 1 - y + 1 < draw.Height)
                    draw.SetPixel(x, draw.Height - 1 - y + 1, color); // up
                if (draw.Height - 1 - y - 1 >= 0)
                    draw.SetPixel(x, draw.Height - 1 - y - 1, color); //down
                if (x - 1 >= 0)
                    draw.SetPixel(x - 1, draw.Height - 1 - y, color);  //left
                if (x + 1 < draw.Width)
                    draw.SetPixel(x + 1, draw.Height - 1 - y, color);  //right
            }

            if (thickness == 3)
            {
                if (draw.Height - 1 - y + 2 < draw.Height)
                    draw.SetPixel(x, draw.Height - 1 - y + 2, color); // up2
                if (draw.Height - 1 - y - 2 >= 0)
                    draw.SetPixel(x, draw.Height - 1 - y - 2, color); //down2
                if (draw.Height - 1 - y + 1 < draw.Height && x - 1 >= 0)
                    draw.SetPixel(x - 1, draw.Height - 1 - y + 1, color); // up left
                if (draw.Height - 1 - y + 1 < draw.Height && x + 1 < draw.Width)
                    draw.SetPixel(x + 1, draw.Height - 1 - y + 1, color); // up right
                if (x - 2 >= 0)
                    draw.SetPixel(x - 2, draw.Height - 1 - y, color);  //left2
                if (x + 2 < draw.Width)
                    draw.SetPixel(x + 2, draw.Height - 1 - y, color);  //right2
                if (draw.Height - 1 - y - 1 >= 0 && x - 1 >= 0)
                    draw.SetPixel(x - 1, draw.Height - 1 - y - 1, color); //down left
                if (draw.Height - 1 - y - 1 >= 0 && x + 1 < draw.Width)
                    draw.SetPixel(x + 1, draw.Height - 1 - y - 1, color);  //down right
            }

        }
        #endregion

        #region Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}