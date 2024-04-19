namespace LineComparison
{
    internal class Program
    {
        
        static Program()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
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

           double length = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));

            Console.WriteLine($"Length of a line : {length}");
        }
    }
}
