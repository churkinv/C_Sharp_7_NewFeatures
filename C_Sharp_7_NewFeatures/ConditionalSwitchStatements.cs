using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp_7_NewFeatures
{
    public class ConditionalSwitchStatements
    {
        public void Run()
        {
            Employee theEmmployee = new VicePresident();
            theEmmployee.Salary = 175000;
            theEmmployee.Years = 7;
            (theEmmployee as VicePresident).NumberManaged = 200;
            (theEmmployee as VicePresident).StockShares = 6000;

            //we can create conditions using when keyword and display result under certain criteria
            switch (theEmmployee)
            {
                case VicePresident vp when (vp.StockShares < 5000):   // Examples with figures: case Triangle(int Width, int Height, int Base)
                    WriteLine($"Junior VP with: {vp.StockShares} shares");
                    break;

                case VicePresident vp when (vp.StockShares >= 5000):
                    WriteLine($"Senior VP with: {vp.StockShares} shares");
                    break;

                case Manager m: // important: the order of declaration of cases here is matter, 
                                // if we put Employee at first it would say say it is already handled by previous case. 
                                // So in this case we could have kind of if statements 
                    WriteLine($"Number of managed employees {m.NumberManaged}");
                    break;

                case Employee e:
                    WriteLine($"Employee with salary {e.Salary}");
                    break;
            }
        }
    }

    public class Employee
    {
        public int Salary { get; set; }
        public int Years { get; set; }
    }

    public class Manager : Employee
    {
        public int NumberManaged { get; set; }
    }

    public class VicePresident : Manager
    {
        public int StockShares { get; set; }
    }
}
