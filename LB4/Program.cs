using System;
using System.Collections.Generic;

namespace LB4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int s_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите систему счисления: ");
            int s = Convert.ToInt32(Console.ReadLine());
            int f_num = 0;
            Stack<int> stack = new Stack<int>();
            while (s_num>=s)
            {
                int x = s_num % s;
                stack.Push(x);
                s_num /= s;
            }
            if (s_num > 0)
            {
                stack.Push(s_num);
            }
            int l = stack.Count;
            for (int i = l-1; i >= 0 && stack.Count>0; i++)
            {
                f_num += (int)(stack.Pop() * Math.Pow(10, i));
            }
            Console.WriteLine($"Результат:{f_num}");
            Console.ReadKey();
        }
    }
}
