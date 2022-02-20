using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    public class CheckIfLineAreEqual
    {
        public static bool EqualityOfLine()
        {
            double Line1 = CreatingLine.CreateLine();
            double Line2 = CreatingLine.CreateLine();
            if (Line1 == Line2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
