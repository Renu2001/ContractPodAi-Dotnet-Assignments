namespace LineComparison
{
    internal class Program
    {
        
        static Program()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
        }

        public void LengthOfLine(int x1, int y1, int x2, int y2)
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine($"Length of a line : {length}");
            
        }
        static void Main(string[] args)
        {
           Console.Write("Enter x1 : ");
           int x1 = Convert .ToInt32(Console.ReadLine());

           Console.Write("Enter y1 : ");
           int y1 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Enter x2 : ");
           int x2 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Enter y2 : ");
           int y2 = Convert.ToInt32(Console.ReadLine());

            Program var = new Program();
            var.LengthOfLine(x1, y1, x2, y2);
           
        }
    }
}
