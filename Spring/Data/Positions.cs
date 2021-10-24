using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Data
{
    public class Positions
    {
        public readonly object lockObject = new object { };
        public double w;
        public double x;
    }
}
