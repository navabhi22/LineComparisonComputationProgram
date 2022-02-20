using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    public class ToCompareTheLines
    {
        public static void ToCompareLines()
        {
            double Line1 = CreatingLine.CreateLine();
            double Line2 = CreatingLine.CreateLine();
            
            if (Line1 > Line2)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else if (Line1 < Line2)
            {
                Console.WriteLine("Line2 is greater than Line1 ");
            }
            else
            {
                Console.WriteLine("Lines are equal");
            }
        }
    }
}
