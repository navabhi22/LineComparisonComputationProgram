using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    public class CreatingLine
    {
        /// <summary>
        /// Creates the line.
        /// </summary>
        /// 
        public static void CreateLine()
        {
            Random random = new Random();
            int x1 = random.Next(10);
            int y1 = random.Next(10);

            int x2 = random.Next(10);
            int y2 = random.Next(10);

              double LineLength = Math.Sqrt(Math.Pow((x2 - x1),2) + (Math.Pow((y2 - y1),2)));
                Console.WriteLine("The length of line is  " + LineLength);

            
        }
    }
}
