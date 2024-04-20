﻿namespace LineComparison
{
    internal class Program
    {
        int x1, x2, y1, y2;

        public Program()
        {
            Console.Write("Enter x1 : ");
            this.x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y1 : ");
            this.y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter x2 : ");
            this.x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y2 : ");
            this.y2 = Convert.ToInt32(Console.ReadLine());
        }
        static Program()
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
            if(line1.Equals(line2))
            {
                Console.WriteLine("Both lines are Equal");
            }
            else
            {
                Console.WriteLine("Both lines are Not Equal");
            }
        }
        static void Main(string[] args)
        {
            Program var1 = new Program();
            double line1 = var1.LengthOfLine();

            Program var2 = new Program ();
            double line2 = var2.LengthOfLine();

            var2.CheckEquality(line1, line2);
           
        }
    }
}
