using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;

namespace CGLab1
{
    abstract public class ConvolutionFilter
    {

        abstract public double[,] _matrix { get; set; }

        public int rows {get; set;}
        public int cols { get; set; }

        public int Size { get; set; }  

        public double this[int i, int j] => _matrix[i, j];

        public int Divisor { get; set; }
        public int Offset { get; set; }



        public static Color operator *(Color[,] map, ConvolutionFilter filter)
        {
            if ((int)Math.Sqrt(map.Length) != filter.Size)
                throw new ArgumentException("Different sizes in multiplication");

            double red = 0;
            double green = 0;
            double blue = 0;


            for (int y = 0; y < filter.Size; y++)
            {
                for (int x = 0; x < filter.Size; x++)
                {
                    red += map[y, x].R * filter[y, x];
                    green += map[y, x].G * filter[y, x];
                    blue += map[y, x].B * filter[y, x];
                  
                }
            }

            return Color.FromArgb(Normalize(red, filter), Normalize(green, filter), Normalize(blue, filter));
        }

        protected static int Normalize(double value, ConvolutionFilter filter)
        {
            if (filter.Divisor == 0) filter.Divisor = 1;
            return Math.Min(Math.Max((int)(value / filter.Divisor + filter.Offset), 0), 255);
        }



    }

    //Predefined Convolution Filters
    public class UserFilter : ConvolutionFilter
    {
        public override double[,] _matrix { get; set; }

        public UserFilter(ConvMatrix conv)
        {

            rows = conv.rows;
            cols = conv.columns;
            _matrix = conv._matrix;
            Offset = conv.offset;
           
            Size = (int)Math.Sqrt(conv._matrix.Length);
        }      
           
    }

    public class BlurFilter : ConvolutionFilter
    {
       
        public override double[,] _matrix { get; set; } = {
            {1, 1, 1},
            {1, 1, 1},
            {1, 1, 1}
        };       

        public BlurFilter()
        {
            Size = (int)Math.Sqrt(_matrix.Length);
        }
    }

    public class GaussianSmoothingFilter : ConvolutionFilter
    {
        public override double[,] _matrix { get; set; } = {
            {0, 1, 0},
            {1, 4, 1},
            {0, 1, 0}
        };
        
        public GaussianSmoothingFilter()
        {
            Size = (int)Math.Sqrt(_matrix.Length);
        }
    }

    public class SharpenFilter : ConvolutionFilter
    {
        public override double[,] _matrix { get; set; } = {
           {0, -1, 0},
           {-1, 5, -1},
           {0, -1, 0}
        };

        public SharpenFilter()
        {
            Size = (int)Math.Sqrt(_matrix.Length);
        }
    }

    public class EdgeHorizontalFilter : ConvolutionFilter
    {
        public override double[,] _matrix { get; set; } = {
            {0, -1, 0},
            {0, 1, 0},
            {0, 0, 0}
        };

        public EdgeHorizontalFilter()
        {
            Size = (int)Math.Sqrt(_matrix.Length);
        }
    }

    public class EdgeVerticalFilter : ConvolutionFilter
    {
        public override double[,] _matrix { get; set; } = {
           {0, 0, 0},
           {-1, 1, 0},
           {0, 0, 0}
        };

        public EdgeVerticalFilter()
        {
            Size = (int)Math.Sqrt(_matrix.Length);
        }
    }

    public class EdgeDiagonalFilter : ConvolutionFilter
    {
        public override double[,] _matrix { get; set; } = {
           { -1, 0, 0 },
           { 0, 1, 0 },
           { 0, 0, 0 }
        };

        public EdgeDiagonalFilter()
        {
            Size = (int)Math.Sqrt(_matrix.Length);
        }

    }

    public class EmbossNorthFilter : ConvolutionFilter
    {
        public override double[,] _matrix { get; set; } = {
         {1, 1, 1},
         {0, 0, 0},
         {-1, -1, -1}
        };

        public EmbossNorthFilter()
        {
            Size = (int)Math.Sqrt(_matrix.Length);
        }
    }

    public class EmbossSouthFilter : ConvolutionFilter
    {
        public override double[,] _matrix { get; set; } = {
           {-1, -1, -1},
           {0, 0, 0},
           {1, 1, 1}
        };

        public EmbossSouthFilter()
        {
            Size = (int)Math.Sqrt(_matrix.Length);
        }
    }

    public class EmbossEastFilter : ConvolutionFilter
    {
        public override double[,] _matrix { get; set; } = {
          {-1, 0, 1},
          {-1, 0, 1},
          {-1, 0, 1}
        };

        public EmbossEastFilter()
        {
            Size = (int)Math.Sqrt(_matrix.Length);
        }
    }

    public class EmbossWestFilter : ConvolutionFilter
    {
        public override double[,] _matrix { get; set; } = {
          {1, 0, -1},
          {1, 0, -1},
          {1, 0, -1}
        };

        public EmbossWestFilter()
        {
            Size = (int)Math.Sqrt(_matrix.Length);
        }
    }

    public class EmbossSouthEastFilter : ConvolutionFilter
    {
        public override double[,] _matrix { get; set; } = {
          {-1, -1, 0},
          {-1, 1, 1},
          {0, 1, 1}
        };

        public EmbossSouthEastFilter()
        {
            Size = (int)Math.Sqrt(_matrix.Length);
        }
    }



}
