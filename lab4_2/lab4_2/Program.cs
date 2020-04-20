//C:\Users\Danik\source\repos\MathLibrary\Debug

using System;
using System.Runtime.InteropServices;

namespace Lab4_2
{

    class Program
    {
        [DllImport("C:\\Users\\Danik\\source\\repos\\MathLibrary\\Debug\\MATHLIBRARY.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Sum(int a, int b);

        [DllImport("C:\\Users\\Danik\\source\\repos\\MathLibrary\\Debug\\MATHLIBRARY.dll")]
        public static extern int Diff(int a, int b);

        [DllImport("C:\\Users\\Danik\\source\\repos\\MathLibrary\\Debug\\MATHLIBRARY.dll")]

        public static extern int Division(int a, int b);

        static void Main(string[] args)
        {
            int sum = Sum(10, 20);
            int dif = Diff(30, 20);
            float div = Division(14, 2);
            Console.WriteLine($"10 + 20 = {sum.ToString()}");
            Console.WriteLine($"30 - 20 = {dif.ToString()}");
            Console.WriteLine($"14 : 2 = {div.ToString()}");
        }
    }
}