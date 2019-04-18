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
    public partial class Form1 : Form
    {
        public Bitmap original, modified;

        public Form1()
        {
             InitializeComponent();
             original = modified = null;
             
        }

        #region New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPG(*.JPG)|*.jpg";

            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                original = (Bitmap)Image.FromFile(fd.FileName);
                originalPictureBox.Image = original;

            }
            modified = original;
        }
        #endregion

        #region Functional Filters
        private void identityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null)
                return;

            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    Color pixel = original.GetPixel(i, j);
                    modified.SetPixel(i, j, pixel);
                }
            filteredPictureBox.Image = modified;

        }

        private void inverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null)
                return;

            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    Color pixel = original.GetPixel(i, j);
                    byte r = pixel.R;
                    byte g = pixel.G;
                    byte b = pixel.B;

                    pixel = Color.FromArgb(255 - r, 255 - g, 255 - b);
                    modified.SetPixel(i, j, pixel);
                }
            filteredPictureBox.Image = modified;
        }

        private void changeBrightness(bool increment, uint value)
        {
            if (original == null)
                return;
         
            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    Color pixel = original.GetPixel(i, j);
                    uint r = pixel.R;
                    uint g = pixel.G;
                    uint b = pixel.B;


                    if (increment)
                    {
                        r += value; if (r > 255) r = 255;
                        g += value; if (g > 255) g = 255;
                        b += value; if (b > 255) b = 255;
                    }
                    else
                    {
                        r -= value; if (r > 255) r = 0;
                        g -= value; if (g > 255) g = 0;
                        b -= value; if (b > 255) b = 0;
                    }

                    pixel = Color.FromArgb((byte)r, (byte)g, (byte)b);
                    modified.SetPixel(i, j, pixel);
           
                }
            filteredPictureBox.Image = modified;
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeBrightness(true, 50);
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeBrightness(false, 50);
        }

        private void changeContrast(double a)
        {
            if (original == null)
                return;

            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    Color pixel = original.GetPixel(i, j);

                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    r = (int)(a * (r - 127) + 127);
                    g = (int)(a * (g - 127) + 127);
                    b = (int)(a * (b - 127) + 127);

                    if (r < 0) r = 0;
                    if (r > 255) r = 255;

                    if (g < 0) g = 0;
                    if (g > 255) g = 255;

                    if (b < 0) b = 0;
                    if (b > 255) b = 255;

                    pixel = Color.FromArgb((byte)r, (byte)g, (byte)b);
                    modified.SetPixel(i, j, pixel);
                }

            filteredPictureBox.Image = modified;

        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeContrast(2);
        }

        private void setGamma(double gamma)
        {

            if (original == null)
                return;

            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    Color pixel = ((Bitmap)original).GetPixel(i, j);
                    double r = pixel.R;
                    double g = pixel.G;
                    double b = pixel.B;

                    r = Math.Pow(r / 255, gamma) * 255;
                    g = Math.Pow(g / 255, gamma) * 255;
                    b = Math.Pow(b / 255, gamma) * 255;

                    if (r < 0) r = 0;
                    if (r > 255) r = 255;

                    if (g < 0) g = 0;
                    if (g > 255) g = 255;

                    if (b < 0) b = 0;
                    if (b > 255) b = 255;


                    pixel = Color.FromArgb((byte)r, (byte)g, (byte)b);
                    modified.SetPixel(i, j, pixel);
                }
            filteredPictureBox.Image = modified;
        }

        private void gammaCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GammaSetterr gammaSetter = new GammaSetterr();
            gammaSetter.ShowDialog();
            double value = gammaSetter.gamma;
            setGamma(value);
           
        }

        #endregion

        #region Convolution Filters

        public Bitmap ComputeWith(ConvolutionFilter filter)
        {
            var result = new Bitmap(original.Width, original.Height);
            var offset = filter.Size / 2;

            filter.Offset = 0;
            for (int i = 0; i < filter.Size; i++)
            {
                for (int j = 0; j < filter.Size; j++)
                {
                    filter.Divisor += (int)filter._matrix[i, j];
                }
            }
           
            if (filter.Divisor == 0) filter.Divisor = 1;
            

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    
                    var colorMap = new Color[filter.Size, filter.Size];

                    for (int filterY = 0; filterY < filter.Size; filterY++)
                    {
                        int pk = (filterY + x - offset <= 0) ? 0 :
                            (filterY + x - offset >= original.Width - 1) ? original.Width - 1 : filterY + x - offset;
                        for (int filterX = 0; filterX < filter.Size; filterX++)
                        {
                            int pl = (filterX + y - offset <= 0) ? 0 :
                                (filterX + y - offset >= original.Height - 1) ? original.Height - 1 : filterX + y - offset;

                            colorMap[filterY, filterX] = original.GetPixel(pk, pl);
                        }
                    }

                    result.SetPixel(x, y, colorMap * filter);              
                }
            }

            original = result;
            return result;

        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null)
            return;

           modified = ComputeWith(new BlurFilter());
           filteredPictureBox.Image = modified;
        }

        private void gausToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (original == null)
           return;

           modified =  ComputeWith(new GaussianSmoothingFilter());
           filteredPictureBox.Image = modified;
        }

        private void sharpenFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (original == null)
           return;
  
          modified = ComputeWith(new SharpenFilter());
          filteredPictureBox.Image = modified;
        }

       private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (original == null)
           return;

           modified = ComputeWith(new EdgeHorizontalFilter());
           filteredPictureBox.Image = modified;
       }

       private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (original == null)
           return;

            modified = ComputeWith(new EdgeVerticalFilter());
           filteredPictureBox.Image = modified;
       }

       private void diagonalToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (original == null)
           return;

           modified = ComputeWith(new EdgeDiagonalFilter());
           filteredPictureBox.Image = modified;
       }
   
       private void northToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (original == null)
           return;

         modified = ComputeWith(new EmbossNorthFilter());
           filteredPictureBox.Image = modified;
       }

       private void southToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (original == null)
           return;

         modified = ComputeWith(new EmbossSouthFilter());
           filteredPictureBox.Image = modified;
       }

       private void eastToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (original == null)
           return;

           modified = ComputeWith(new EmbossEastFilter());
           filteredPictureBox.Image = modified;
       }

       private void westToolStripMenuItem_Click(object sender, EventArgs e)
      {
           if (original == null)
           return;

          modified = ComputeWith(new EmbossWestFilter());
          filteredPictureBox.Image = modified;
      }

       private void southEastToolStripMenuItem_Click(object sender, EventArgs e)
      {
          if (original == null)
           return;

          modified = ComputeWith(new EmbossSouthEastFilter());
          filteredPictureBox.Image = modified;
       }


        #endregion

        #region Matrix
        private void matrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (original == null)
           return;

           ConvMatrix convMatrix = new ConvMatrix();
           convMatrix.ShowDialog();

           double[,] matrix = convMatrix._matrix;
 
           modified = ComputeWith(new UserFilter(convMatrix));
           filteredPictureBox.Image = modified;
        }


        #endregion      
      

        #region Lab2
        private void greyScaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (original == null)
                return;

            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    Color pixel = original.GetPixel(i, j);
                    // GreyScale
                    uint I = (uint)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);

                    pixel = Color.FromArgb((byte)I, (byte)I, (byte)I);

                    modified.SetPixel(i, j, pixel);
                }
            filteredPictureBox.Image = modified;
        }

        private void applyThreshold(int K, double T)
        {
            if (original == null)
                return;

            int[] values = new int[K];
            values[0] = 0; values[K - 1] = 255;
            for (int i = 1; i < K; i++)
                values[i] = (i * (255 / (K - 1)));

            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    Color pixel = original.GetPixel(i, j);
                    int I = pixel.R;
                    int set = 0;

                    int lowerbound;
                    int upperbound;

                    for (int k = 0; k < K - 1; k++)
                        if (I >= values[k] && I <= values[k + 1])
                        {
                            lowerbound = values[k];
                            upperbound = values[k + 1];

                            double tr = lowerbound + T * (upperbound - lowerbound);
                            if (I >= tr)
                                set = upperbound;
                            else
                                set = lowerbound;

                            break;
                        }

                    pixel = Color.FromArgb((byte)set, (byte)set, (byte)set);
                    modified.SetPixel(i, j, pixel);
                }
            filteredPictureBox.Image = modified;
        }

        private void applyThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Threshold threshold = new Threshold();
            threshold.ShowDialog();

            int M = threshold.M;
            double T = threshold.T;

            applyThreshold(M, T);
        }

        private void applyRandomDithering(int K)
        {
            if (original == null)
                return;

            Random r = new Random(Guid.NewGuid().GetHashCode());

            uint[] values = new uint[K];
            values[0] = 0; values[K - 1] = 255;
            for (int i = 1; i < K; i++)
                values[i] = (uint)(i * (255 / (K - 1)));

            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    Color pixel = original.GetPixel(i, j);
                    uint I = pixel.R;
                    uint set = 0;

                    uint lowerbound;
                    uint upperbound;

                    for (int k = 0; k < K - 1; k++)
                        if (I >= values[k] && I <= values[k + 1])
                        {
                            lowerbound = values[k];
                            upperbound = values[k + 1];
                            uint tr = (uint)r.Next((int)lowerbound, (int)upperbound);
                            if (I >= tr)
                                set = upperbound;
                            else
                                set = lowerbound;

                            break;
                        }

                    pixel = Color.FromArgb((byte)set, (byte)set, (byte)set);
                    modified.SetPixel(i, j, pixel);
                }
            filteredPictureBox.Image = modified;
        }

        private void randomDitheringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null) return;

            RandomDithering randomDithering = new RandomDithering();
            randomDithering.ShowDialog();

            int K = randomDithering.K;
            applyRandomDithering(K);

        }

        private void octreeColorQuantizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (original == null) return;

            Octree octree = new Octree();
            octree.ShowDialog();
            OctreeQuantizer quantizer = new OctreeQuantizer();
            for (int j = 0; j < original.Height; j++)
            {
                for (int i = 0; i < original.Width; i++)
                {
                    Color c = original.GetPixel(i, j);
                    quantizer.AddColor(c);


                }
            }

            int availableColors = octree.availableColors;
           
            List<Color> limitedPalette = new List<Color>();
            limitedPalette = quantizer.GetPalette(availableColors);

            modified = new Bitmap(original.Width, original.Height);
            for (int j = 0; j < original.Height; j++)
            {
                for (int i = 0; i < original.Width; i++)
                {

                    modified.SetPixel(i, j, limitedPalette[quantizer.GetPaletteIndex(original.GetPixel(i, j))]);
                }
            }

            filteredPictureBox.Image = modified;
        }


        #endregion

        #region Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
