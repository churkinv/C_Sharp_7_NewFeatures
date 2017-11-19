using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp_7_NewFeatures
{
    class OutVariables
    {
        public void Run() // traditional way
        {
            int hours;
            int minutes;
            int seconds;

            GetTime(out hours, out minutes, out seconds);

            WriteLine($"{hours}:{minutes}:{seconds}");
        }

        public void RunVariablesOut() // and new much cleaner way, and the same result
        {
            GetTime(out int hours, out int minutes, out int seconds);
            WriteLine($"{hours}:{minutes}:{seconds}");
        }

        public void GetTime(out int hours, out int minutes, out int seconds)
        {
            hours = 1;
            minutes = 30;
            seconds = 20;
        }
    }
}
