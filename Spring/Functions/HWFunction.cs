using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Functions
{
    public static class HWFunction
    {
        public static double CountHW(int index, double A, double t, double w, double q)
        {
            double result = 0;
            switch (index)
            {
                case 0:
                    result = A;
                    break;
                case 1:
                    result = A;
                    break;
                case 2:
                    result = A * Math.Sign(Math.Sin(w * t + q));
                    break;
                case 3:
                    result = A * Math.Sin(w * t + q);
                    break;
            }

            return result;
        }
    }
}
