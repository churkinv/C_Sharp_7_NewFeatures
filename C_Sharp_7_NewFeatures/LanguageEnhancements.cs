using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_7_NewFeatures
{
    public class LanguageEnhancements
    {
        public int GetBigNumber()
        {
            return 1_234_567; // and it will return 1234567
        }

        public ref int Substitute(int value, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == value)
                {
                    return ref numbers[i];
                }
            }
            throw new IndexOutOfRangeException("Not Found");
        }     
    }

    public class Hero
    {
        public string Name { get; }

        public Hero(string name) =>
            Name = name ?? throw new ArgumentNullException();
    }
}
