namespace W26Week1ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;

            Console.WriteLine("\nArea = " + area);
        }
    }
}
