using System.Globalization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = DateTime.Now;
            int rocYear = x.Year - 1911;
            string rocDate = $"{rocYear}/{x.ToString("MM/dd HH:mm:ss fff", CultureInfo.InvariantCulture)}";
            Console.WriteLine(x);
            Console.WriteLine(rocDate);
        }
    }
}