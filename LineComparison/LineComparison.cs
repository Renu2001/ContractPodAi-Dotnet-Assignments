using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineComparison : ILineComparison
    {
        int x1, x2, y1, y2;

        public LineComparison()
        {
            Console.Write("Enter x1 Coordinate : ");
            this.x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y1 Coordinate : ");
            this.y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter x2 Coordinate : ");
            this.x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y2 Coordinate : ");
            this.y2 = Convert.ToInt32(Console.ReadLine());
        }
        static LineComparison()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
        }

        public double LengthOfLine()
        {
            double length = Math.Sqrt(Math.Pow((this.x2 - this.x1), 2) + Math.Pow((this.y2 - this.y1), 2));
            Console.WriteLine($"Length of a line : {length}");
            return length;

        }

        public void CheckEquality(double line1, double line2)
        {
            if (line1.Equals(line2))
            {
                Console.WriteLine("Both Lines are Equal");
            }
            else
            {
                Console.WriteLine("Both Lines are Not Equal");
            }
        }

        public void Compare(double line1, double line2)
        {
            int result = line1.CompareTo(line2);
            if (result < 0)
            {
                Console.WriteLine("Line 1 is less than Line 2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else
            {
                Console.WriteLine("Both Lines are Equal ");
            }
        }
    }
}
