namespace LineComparison
{
    internal class Program : LineComparison
    {
        
        static void Main(string[] args)
        {
            LineComparison var1 = new LineComparison();
            double line1 = var1.LengthOfLine();

            LineComparison var2 = new LineComparison();
            double line2 = var2.LengthOfLine();

            var2.CheckEquality(line1, line2);
            var2.Compare(line1, line2);
           
        }

       
    }
}
