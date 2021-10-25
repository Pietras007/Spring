using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Data
{
    public class DataModel
    {
        public readonly object lockObject = new object { };
        public double h_tValue;
        public double w_tValue;
        public double f_tvalue;
        public double g_tvalue;
        public double xi_1;
        public double vi_1;
        public double x_tvalue;
        public double xt_tvalue;
        public double xtt_tValue;
        public double time_s;
    }
}
