using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodionov_Investments
{
    class Currency
    {
        public double value;
        private double k;
        
        public Currency(double val, double k) { value = val; this.k = k; }
        public double nextvalue(double randomvalue) { return value *= (1 + k * (randomvalue - 0.5)); }
    }
}
