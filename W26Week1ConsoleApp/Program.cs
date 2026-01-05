namespace W26Week1ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter radius: ");
            //double r = double.Parse(Console.ReadLine());

            //double area = Math.PI * r * r;

            //Console.WriteLine("\nArea = " + area);


            int[] numbers = { 10, 20, 0, 30 };
            int total = 0;
            int count = numbers.Length;

            for (int i = 0; i < count; i++) // off-by-one error
            {
                total += numbers[i];
            }

            int average = total / count;
            Console.WriteLine("Average: " + average);
        }
    }
}
