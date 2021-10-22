using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Functions
{
    public static class HWFunction
    {
        public static void CountHW(int index, string text, List<double> values, List<double> values2, double t, double w, double q)
        {
            double result = 0;
            double _t = t / 1000.0f;
            double A;
            if (double.TryParse(text, out A))
            {
                switch (index)
                {
                    case 0:
                        result = A;
                        break;
                    case 1:
                        result = A;
                        break;
                    case 2:
                        result = A * Math.Sign(Math.Sin(w * _t + q));
                        break;
                    case 3:
                        result = A * Math.Sin(w * _t + q);
                        break;
                }

                if (values.Contains(double.MinValue))
                {
                    int idx = values.IndexOf(double.MinValue);
                    values[idx] = result;
                    for (int i = 0; i < values.Count; i++)
                    {
                        if (values[i] == double.MinValue)
                        {
                            values2[i] = 0;
                        }
                        else
                            values2[i] = values[i];
                    }
                }
                else
                {
                    values.RemoveAt(0);
                    values.Add(result);
                    for (int i = 0; i < values.Count; i++)
                    {
                        values2[i] = values[i];
                    }
                }
            }
        }
    }
}
