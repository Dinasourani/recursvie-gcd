using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static int maghsom(int a, int b)
        {
            if (b == 0)
                return a;
            return maghsom(b, a % b);
        }
        static void Main(string[] args)
        {
             Console.Write("عدد اول را وارد کنید: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("عدد دوم را وارد کنید: ");
        int num2 = int.Parse(Console.ReadLine());

        int result = maghsom(num1, num2);

        Console.WriteLine("بزرگ‌ترین مقسوم‌علیه مشترک  برابر است با:", result);
        Console.ReadKey();
        }
        
    }
}
