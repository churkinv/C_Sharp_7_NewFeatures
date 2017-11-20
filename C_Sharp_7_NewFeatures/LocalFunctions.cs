using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_7_NewFeatures
{
    public class LocalFunctions
    {
        public int Fibonacci(int x)
        {
            if (x < 0) throw new ArgumentException(
                   "Must be at least 0", nameof(x));
            return Fib(x).current;

            (int current, int previous) Fib (int i)
            {
                if (i == 0) return (1, 0);
                var (current, previous) = Fib(i - 1);
                return (current + previous, current);
            }
        }
    }
}
