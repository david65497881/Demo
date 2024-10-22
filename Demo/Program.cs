using System.Globalization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = DateTime.Now;
            int rocYear = x.Year - 1911;
            string rocDate = $"{rocYear}/{x.ToString("MM/dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}";
            //CultureInfo.InvariantCulture 代表.NET 中的一個靜態屬性 代表一個不變的文化（Invariant Culture）
            //通常用於：字串比較、數字-日期格式化與解析、序列化與反序列化
            Console.WriteLine(x);
            Console.WriteLine(rocDate);
        }
    }
}