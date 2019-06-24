using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGLab4
{
    public partial class ClippingAndFilling : Form
    {
        private Bitmap bitmap;
        private int x1, x2;
        private int y1, y2;

        private bool clipping = false;
        private bool filling = false;
        private bool lab = false;

        private bool getLine = false;
        private bool getPolygon = false;

        public List<Point> polyPoints;
        public List<Point> line;

        private List<Edge> EdgeTable;

        private const int COLORS_NUMBER = 4;
        private Color color;

        public Graphics graphics;
        public Pen pen;
        Point v;

        public ClippingAndFilling()
        {
            int seed = 1;
            Random r = new Random(seed);
            color = Color.Red;
            InitializeComponent();

            bitmap = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            mainPictureBox.Image = bitmap;

            polyPoints = new List<Point>();//{ new Point(220, 50), new Point(200, 180), new Point(40, 200), new Point(50, 90) };
            line = new List<Point>();
            EdgeTable = new List<Edge>();

            graphics = mainPictureBox.CreateGraphics();
            pen = new Pen(Color.Black, 1);

            clipping = true;
            getPolygon = true;
            x1 = x2 = y1 = y2 = -1;         
            lineButton.Visible = false;
            xLineLabel.Visible = false;
            yLineLabel.Visible = false;
            clipButton.Visible = false;
            fillButton.Visible = false;
            labButton.Visible = false;


            for (int i = 0; i < COLORS_NUMBER; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = pb.Height = 25;
                pb.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                pb.Click += pb_Click;
                colorFlowLayoutPanel.Controls.Add(pb);
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
            color = ((PictureBox)sender).BackColor;
        }

        #region MenuStrips
        private void clippingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bitmap.Height; i++)
                for (int j = 0; j < bitmap.Width; j++)
                    bitmap.SetPixel(j, i, Color.White);

            mainPictureBox.Image = bitmap;

            polyPoints.Clear();
            EdgeTable.Clear();

            clipping = true;
            filling = false;
            lab = false;
            clipButton.Visible = false;
            fillButton.Visible = false;
            mode.Text = "MODE: Clipping";
        }

        private void fillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bitmap.Height; i++)
                for (int j = 0; j < bitmap.Width; j++)
                    bitmap.SetPixel(j, i, Color.White);

            mainPictureBox.Image = bitmap;

            polyPoints.Clear();
            EdgeTable.Clear();

            clipping = false;
            filling = true;
            lab = false;
            mode.Text = "MODE: Filling";
            clipButton.Visible = false;      
            fillButton.Visible = false;
            polyButton.Visible = true;
            getLine = false;
            lineButton.Visible = false;
            xLineLabel.Visible = false;
            yLineLabel.Visible = false;
        }

        private void labToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bitmap.Height; i++)
                for (int j = 0; j < bitmap.Width; j++)
                    bitmap.SetPixel(j, i, Color.White);

            mainPictureBox.Image = bitmap;

            polyPoints.Clear();
            EdgeTable.Clear();

            clipping = false;
            filling = false;
            lab = true;
            polyButton.Visible = true;
            
            clipButton.Visible = false;
            fillButton.Visible = false;
            getLine = false;
            lineButton.Visible = false;
            xLineLabel.Visible = false;
            yLineLabel.Visible = false;
            xPolyLabel.Visible = false;
            yPolyLabel.Visible = false;

            labButton.Visible = true;

            mode.Text = "MODE: Lab";

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region DrawingRegion

        private void mainPictureBox_Click(object sender, EventArgs e)
        {
            x1 = ((MouseEventArgs)e).X;
            y1 = ((MouseEventArgs)e).Y;

            if (clipping)
            {
                getPolygon = true;
       
                //  getLine = true;
                //     et_mainPictureBox_Click(sender, e);
             
            }
            else if (filling)
            {
                clipping = false;
                getPolygon = false;
                getLine = false;
                et_mainPictureBox_Click(sender, e);
            }else if (lab)
            {
                getPolygon = false;
                clipping = false;
                filling = false;
                et_mainPictureBox_Click(sender, e);

            }


            if (getLine)
            {

                //getLine = false;
                //int x = ((MouseEventArgs)e).X;
                //int y = ((MouseEventArgs)e).Y;

                xLineLabel.Text = "x: " + x1;
                yLineLabel.Text = "y: " + y1;

                v = new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                if (line.Count() == 2)
                    line.Clear();
                line.Add(v);
            }

            else if (getPolygon)
            {
                xPolyLabel.Text = "x: " + ((MouseEventArgs)e).X;
                yPolyLabel.Text = "y: " + ((MouseEventArgs)e).Y;
                v = new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                if (polyPoints.Count() == 4)
                    polyPoints.Clear();
                polyPoints.Add(v);
              //   et_mainPictureBox_Click(sender, e);
            }
         
  

        }


        private void mainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            coordinatesLabel.Text = "[" + e.X + ";" + (mainPictureBox.Height - e.Y) + "]";
        }

        #endregion

        #region DrawPolygon
        private void et_mainPictureBox_Click(object sender, EventArgs e)
        {
            polyPoints.Add(new Point(x1, mainPictureBox.Height - y1));
        }

        private void polyButton_Click(object sender, EventArgs e)
        {
            if (clipping)
            {
                PC();
            }
            else if(filling)
            {
                polygonForFilling();
            }else if (lab)
            {
                polygonForLab();
            }
        }

        private void PC()
        {
            Point v1 = polyPoints.First();
            Point temp = v1;
            foreach (var v in polyPoints)
            {
                graphics.DrawLine(pen, temp, v);
                temp = v;
            }
            graphics.DrawLine(pen, temp, v1);


            clipButton.Visible = true;
            polyButton.Visible = false;
            xPolyLabel.Visible = false;
            yPolyLabel.Visible = false;
            getPolygon = false;
            getLine = true;
            lineButton.Visible = true;
            xLineLabel.Visible = true;
            yLineLabel.Visible = true;
        }
        private void polygonForClipping()
        {

            if (polyPoints.Count < 3) return;


            for (int i = 1; i < polyPoints.Count; i++)
            {
                float dx = polyPoints[i - 1].X - polyPoints[i].X;
                float dy = polyPoints[i - 1].Y - polyPoints[i].Y;

                SymmetricLine(polyPoints[i - 1].X, polyPoints[i - 1].Y, polyPoints[i].X, polyPoints[i].Y, true);

                int ymax = Math.Max(polyPoints[i - 1].Y, polyPoints[i].Y);
                int ymin = Math.Min(polyPoints[i - 1].Y, polyPoints[i].Y);
                if (ymin == ymax) continue;
                float xmin = (ymin == polyPoints[i - 1].Y) ? polyPoints[i - 1].X : polyPoints[i].X;

                Edge edge = new Edge(ymax, ymin, xmin, dx / dy, null);

                EdgeTable.Add(edge);

            }
            SymmetricLine(polyPoints[0].X, polyPoints[0].Y, polyPoints[polyPoints.Count - 1].X, polyPoints[polyPoints.Count - 1].Y, true);

            int ymax_last = Math.Max(polyPoints[0].Y, polyPoints[polyPoints.Count - 1].Y);
            int ymin_last = Math.Min(polyPoints[0].Y, polyPoints[polyPoints.Count - 1].Y);
            float xmin_last = (ymin_last == polyPoints[0].Y) ? polyPoints[0].X : polyPoints[polyPoints.Count - 1].X;
            Edge last_edge = new Edge(ymax_last, // ymax
                                      ymin_last, // ymin
                                      xmin_last, //xmin
                    ((float)(polyPoints[polyPoints.Count - 1].X - polyPoints[0].X)) / ((float)(polyPoints[polyPoints.Count - 1].Y - polyPoints[0].Y)),
                    null);

            if (last_edge.yMin != last_edge.yMax)
                EdgeTable.Add(last_edge);

            for (int i = 0; i < EdgeTable.Count; i++)
                EdgeTable[i].next = EdgeTable[(i + 1) % EdgeTable.Count];

            mainPictureBox.Image = bitmap;
            polyPoints.Clear();

            clipButton.Visible = true;
            polyButton.Visible = false;
            xPolyLabel.Visible = false;
            yPolyLabel.Visible = false;
            getPolygon = false;
            getLine = true;         
            lineButton.Visible = true;
            xLineLabel.Visible = true;
            yLineLabel.Visible = true;
        }

        private void polygonForFilling()
        {

            if (polyPoints.Count < 3) return;


            for (int i = 1; i < polyPoints.Count; i++)
            {
                float dx = polyPoints[i - 1].X - polyPoints[i].X;
                float dy = polyPoints[i - 1].Y - polyPoints[i].Y;

                SymmetricLine(polyPoints[i - 1].X, polyPoints[i - 1].Y, polyPoints[i].X, polyPoints[i].Y, true);

                int ymax = Math.Max(polyPoints[i - 1].Y, polyPoints[i].Y);
                int ymin = Math.Min(polyPoints[i - 1].Y, polyPoints[i].Y);
                if (ymin == ymax) continue;
                float xmin = (ymin == polyPoints[i - 1].Y) ? polyPoints[i - 1].X : polyPoints[i].X;

                Edge edge = new Edge(ymax, ymin, xmin, dx / dy, null);

                EdgeTable.Add(edge);

            }
            SymmetricLine(polyPoints[0].X, polyPoints[0].Y, polyPoints[polyPoints.Count - 1].X, polyPoints[polyPoints.Count - 1].Y, true);

            int ymax_last = Math.Max(polyPoints[0].Y, polyPoints[polyPoints.Count - 1].Y);
            int ymin_last = Math.Min(polyPoints[0].Y, polyPoints[polyPoints.Count - 1].Y);
            float xmin_last = (ymin_last == polyPoints[0].Y) ? polyPoints[0].X : polyPoints[polyPoints.Count - 1].X;
            Edge last_edge = new Edge(ymax_last, // ymax
                                      ymin_last, // ymin
                                      xmin_last, //xmin
                    ((float)(polyPoints[polyPoints.Count - 1].X - polyPoints[0].X)) / ((float)(polyPoints[polyPoints.Count - 1].Y - polyPoints[0].Y)),
                    null);

            if (last_edge.yMin != last_edge.yMax)
                EdgeTable.Add(last_edge);

            for (int i = 0; i < EdgeTable.Count; i++)
                EdgeTable[i].next = EdgeTable[(i + 1) % EdgeTable.Count];

            mainPictureBox.Image = bitmap;
            polyPoints.Clear();

            polyButton.Visible = false;
            fillButton.Visible = true;

        }

        private void polygonForLab()
        {

            if (polyPoints.Count < 3) return;


            for (int i = 1; i < polyPoints.Count; i++)
            {
                float dx = polyPoints[i - 1].X - polyPoints[i].X;
                float dy = polyPoints[i - 1].Y - polyPoints[i].Y;

                SymmetricLine(polyPoints[i - 1].X, polyPoints[i - 1].Y, polyPoints[i].X, polyPoints[i].Y, true);

                int ymax = Math.Max(polyPoints[i - 1].Y, polyPoints[i].Y);
                int ymin = Math.Min(polyPoints[i - 1].Y, polyPoints[i].Y);
                if (ymin == ymax) continue;
                float xmin = (ymin == polyPoints[i - 1].Y) ? polyPoints[i - 1].X : polyPoints[i].X;

                Edge edge = new Edge(ymax, ymin, xmin, dx / dy, null);

                EdgeTable.Add(edge);

            }
            SymmetricLine(polyPoints[0].X, polyPoints[0].Y, polyPoints[polyPoints.Count - 1].X, polyPoints[polyPoints.Count - 1].Y, true);

            int ymax_last = Math.Max(polyPoints[0].Y, polyPoints[polyPoints.Count - 1].Y);
            int ymin_last = Math.Min(polyPoints[0].Y, polyPoints[polyPoints.Count - 1].Y);
            float xmin_last = (ymin_last == polyPoints[0].Y) ? polyPoints[0].X : polyPoints[polyPoints.Count - 1].X;
            Edge last_edge = new Edge(ymax_last, // ymax
                                      ymin_last, // ymin
                                      xmin_last, //xmin
                    ((float)(polyPoints[polyPoints.Count - 1].X - polyPoints[0].X)) / ((float)(polyPoints[polyPoints.Count - 1].Y - polyPoints[0].Y)),
                    null);

            if (last_edge.yMin != last_edge.yMax)
                EdgeTable.Add(last_edge);

            for (int i = 0; i < EdgeTable.Count; i++)
                EdgeTable[i].next = EdgeTable[(i + 1) % EdgeTable.Count];

            mainPictureBox.Image = bitmap;
            polyPoints.Clear();

         //   polyButton.Visible = false;
           // labButton.Visible = true;

        }
        #endregion

        #region Clipping

        private void clipButton_Click(object sender, EventArgs e)
        {
            CyrusBeck(polyPoints, line.ElementAt(0), line.ElementAt(1));
        }

        double dotProduct(Point p1, Point p2)
        {
            return p1.X * p2.X + p1.Y * p2.Y;
        }

        Point getInsideNormal(Point p1, Point p2, bool clockwise)
        {
            int delX = p2.X - p1.X;
            int delY = p2.Y - p1.Y;
            Point n = new Point();
            if (clockwise)
                n = new Point(-delY, delX);
            else
                n = new Point(delY, -delX);
            /*Point v = new Point( z.X - p1.X, z.Y - p1.Y );
            double dot = dotProduct(v, n);
            if (dot < 0) //outside normal
            {
                n.X *= -1;
                n.Y *= -1;
            }*/
            return n;
        }

        void CyrusBeck(List<Point> polygon, Point p1, Point p2)
        {
            /*if (p1.X > p2.X)
            {
                Point temp = p1;
                p1 = p2;
                p2 = temp;
            }*/
            int delX = p2.X - p1.X;
            int delY = p2.Y - p1.Y;
            //vector D = Direction vector
            Point D = new Point(delX, delY);

            Point temp1 = polygon.ElementAt(polygon.Count() - 1);
            //Point temp2 = polygon.ElementAt(polygon.Count() - 1);
            double tEnter = 0;
            double tLeave = 1;

            bool clockwise = verifyClockwise(polygon);

            foreach (var p in polygon)
            {
                Point n = getInsideNormal(temp1, p, clockwise);
                temp1 = p;
                Point w = new Point(p1.X - p.X, p1.Y - p.Y);
                double num = dotProduct(w, n);
                double den = dotProduct(D, n);
                if (den == 0) //line and edge are parallel
                {
                    if (num < 0) //w.n<0  -> point/line outside coz P(t) outside polygon
                    {
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }

                double t = -num / den;
                if (den > 0)
                {
                    tEnter = Math.Max(tEnter, t);
                }
                else
                {
                    tLeave = Math.Min(tLeave, t);
                }
            }
            if (tEnter > tLeave)
            {
                return;
            }
            double x1 = p1.X + delX * tEnter;
            double y1 = p1.Y + delY * tEnter;
            double x2 = p1.X + delX * tLeave;
            double y2 = p1.Y + delY * tLeave;
            graphics.DrawLine(new Pen(Color.Red, 2), (int)x1, (int)y1, (int)x2, (int)y2);
        }

        public bool verifyClockwise(List<Point> polygon)
        {
            bool clockwise = false;
            Point p1 = polygon[0];
            Point p2 = polygon[1];
            Point p3 = polygon[2];
            int delX1 = p2.X - p1.X;
            int delX2 = p3.X - p2.X;
            int delY1 = p2.Y - p1.Y;
            int delY2 = p3.Y - p2.Y;

            if ((delY1 > 0 && delX2 < 0) || (delX1 < 0 && delY2 < 0) || (delY1 < 0 && delX2 > 0) || (delX1 > 0 && delY2 > 0))
                clockwise = true;

            return clockwise;

        }



        #endregion

        #region Filling
        private void fillButton_Click(object sender, EventArgs e)
        {
            fillPolygon();
            fillButton.Visible = false;
            polyPoints.Clear();
            EdgeTable.Clear();
            polyButton.Visible = true;
        }

        private void fillPolygon()
        {
            List<Edge> ActiveEdgeTable = new List<Edge>();
            int y = EdgeTable[0].yMax;
            for (int i = 1; i < EdgeTable.Count; i++)
                if (y > EdgeTable[i].yMin)
                    y = EdgeTable[i].yMin;

            while (EdgeTable.Count != 0 || ActiveEdgeTable.Count != 0)
            {
                // move bucket ET[y] to AET 
                for (int i = 0; i < EdgeTable.Count; i++)
                    if (y == EdgeTable[i].yMin)
                    {
                        ActiveEdgeTable.Add(EdgeTable[i]);
                        EdgeTable.Remove(EdgeTable[i--]);
                    }

                // sort AET by x value 
                EdgeCompare ec = new EdgeCompare();
                ActiveEdgeTable.Sort(ec);

                // fill pixels between pairs of intersections
                for (int i = 0; 2 * i + 1 < ActiveEdgeTable.Count; i++)
                    SymmetricLine((int)Math.Round(ActiveEdgeTable[2 * i].xMin), y, (int)Math.Round(ActiveEdgeTable[2 * i + 1].xMin), y, true);

                // increment y
                ++y;
            
                // remove from AET edges for which y = ymax 
                for (int i = 0; i < ActiveEdgeTable.Count; i++)
                    if (y >= ActiveEdgeTable[i].yMax)
                        ActiveEdgeTable.Remove(ActiveEdgeTable[i--]);

                if (y >= 100000)
                {
                    MessageBox.Show("Y > 100 000");
                    break;
                }

                // for each edge in AET x += w
                foreach (Edge edge in ActiveEdgeTable)
                    edge.xMin += edge.w;


            }
        }
        #endregion    

        #region MidpointLine

        private void lineButton_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(pen, line.ElementAt(line.Count - 2), line.ElementAt(line.Count - 1));
            //line.Add(new Point(x1, mainPictureBox.Height - y1));
          //  mainPictureBox.Image = bitmap;
        }

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

        #region SymmetricLine
        private void SymmetricLine(int x1, int y1, int x2, int y2, bool isDecard)
        {
            if (!isDecard)
            {
                y1 = mainPictureBox.Height - y1;
                y2 = mainPictureBox.Height - y2;
            }
            /* check for the right octant */
            if (Math.Abs(y2 - y1) < Math.Abs(x2 - x1))
                if (x1 > x2)
                    SymmetricLineLow(x2, y2, x1, y1);  // IV, 5 
                else
                    SymmetricLineLow(x1, y1, x2, y2);  // 1, VII
            else
                if (y1 > y2)
                SymmetricLineHigh(x2, y2, x1, y1);    // 6, VII
            else
                SymmetricLineHigh(x1, y1, x2, y2); // 2 , III 

            mainPictureBox.Image = bitmap;
        }
        private void SymmetricLineHigh(int x0, int y0, int x1, int y1)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;
            int xi = 1;
            if (dx < 0)
            {
                dx = -dx;
                xi = -1;
            }
            int D = 2 * dx - dy;

            int xf = x0, yf = y0;
            int xb = x1, yb = y1;
            putPixel(xf, yf);
            putPixel(xb, yb);
            while (yf < yb)
            {
                yf++; yb--;

                if (D > 0)
                {
                    xf += xi; xb -= xi;
                    D = D - 2 * dy;
                }
                D = D + 2 * dx;
                putPixel(xf, yf);
                putPixel(xb, yb);

            }
        }
        private void SymmetricLineLow(int x0, int y0, int x1, int y1)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;
            int yi = 1;

            if (dy < 0)
            {
                dy = -dy;
                yi = -1;
            }
            int D = 2 * dy - dx;

            int xf = x0, yf = y0;
            int xb = x1, yb = y1;

            putPixel(xf, yf);
            putPixel(xb, yb);

            while (xf < xb)
            {
                xf++; xb--;

                if (D > 0)
                {
                    yf += yi; yb -= yi;
                    D = D - 2 * dx;
                }
                D = D + 2 * dy;
                putPixel(xf, yf);
                putPixel(xb, yb);
            }
        }
        #endregion

        #region putPixel
        private void putPixel(int x, int y)
        {
            // Decart Coordinate ==>> Graphics Coordinate
            if (x < 0) x = 0;
            if (x >= bitmap.Width) x = bitmap.Width - 1;
            if (y < 0) y = 0;
            if (y >= bitmap.Height) y = bitmap.Height - 1;

            bitmap.SetPixel(x, bitmap.Height - 1 - y, Color.Black);
        }      

        private void putPixel(int x, int y, Color color)
        {
            // Decart Coordinate ==>> Graphics Coordinate
            if (x < 0) x = 0;
            if (x >= bitmap.Width) x = bitmap.Width - 1;
            if (y < 0) y = 0;
            if (y >= bitmap.Height) y = bitmap.Height - 1;

            bitmap.SetPixel(x, bitmap.Height - 1 - y, color);

        }

        #endregion

        #region Lab

        Color prev = Color.White;
        private void labButton_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < bitmap.Height; i++)
            //{
            //    for (int j = 0; j < bitmap.Width; j++)
            //    {
            //        FloodFill4(j, i, bitmap.GetPixel(j,i), Color.Red);

            //    }
            //} bitmap.GetPixel(x1, mainPictureBox.Height - y1)
            //for (int x = 0; x < mainPictureBox.Width; x++)
            //{
            //    for (int y = 0; y < mainPictureBox.Height; y++)
            //    {
            //         FloodFill4(new Point(x, y), boundary, newColor);
            //    }
            //}



            if (prev == Color.White)
            {
                FloodFill(bitmap, new Point(x1, y1), bitmap.GetPixel(x1,y1), color);
                prev = color;
            }
            else
            {
               // prev = color;
                FloodFill(bitmap, new Point(x1, y1), bitmap.GetPixel(x1, y1), color);
            }
           


          
            mainPictureBox.Image = bitmap;
        }

      

        static void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            Queue<Point> q = new Queue<Point>();
            q.Enqueue(pt);
            while (q.Count > 0)
            {
                Point n = q.Dequeue();
                if (!ColorMatch(bmp.GetPixel(n.X, n.Y), targetColor))
                    continue;
                Point w = n, e = new Point(n.X + 1, n.Y);
                while ((w.X >= 0) && ColorMatch(bmp.GetPixel(w.X, w.Y), targetColor))
                {
                    bmp.SetPixel(w.X, w.Y, replacementColor);
                    if ((w.Y > 0) && ColorMatch(bmp.GetPixel(w.X, w.Y - 1), targetColor))
                        q.Enqueue(new Point(w.X, w.Y - 1));
                    if ((w.Y < bmp.Height - 1) && ColorMatch(bmp.GetPixel(w.X, w.Y + 1), targetColor))
                        q.Enqueue(new Point(w.X, w.Y + 1));
                    w.X--;
                }
                while ((e.X <= bmp.Width - 1) && ColorMatch(bmp.GetPixel(e.X, e.Y), targetColor))
                {
                    bmp.SetPixel(e.X, e.Y, replacementColor);
                    if ((e.Y > 0) && ColorMatch(bmp.GetPixel(e.X, e.Y - 1), targetColor))
                        q.Enqueue(new Point(e.X, e.Y - 1));
                    if ((e.Y < bmp.Height - 1) && ColorMatch(bmp.GetPixel(e.X, e.Y + 1), targetColor))
                        q.Enqueue(new Point(e.X, e.Y + 1));
                    e.X++;
                }
            }
        }

        private static bool ColorMatch(Color a, Color b)
        {
            return (a.ToArgb() & 0xffffff) == (b.ToArgb() & 0xffffff);
        }
        #endregion

    }
}
