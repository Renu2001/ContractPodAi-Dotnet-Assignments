namespace LineComparison
{
    internal class Program
    {
        int x1, x2, y1, y2;

        public Program()
        {
            x1=x2=y1=y2=0;
        }
        static Program()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
        }

        public void GetUserInput()
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
        public void LengthOfLine()
        {
            double length = Math.Sqrt(Math.Pow((this.x2 - this.x1), 2) + Math.Pow((this.y2 - this.y1), 2));

            Console.WriteLine($"Length of a line : {length}");
            
        }
        static void Main(string[] args)
        {
            Program var = new Program();
            var.GetUserInput();
            var.LengthOfLine();
           
        }
    }
}
