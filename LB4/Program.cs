using System;
using System.Collections.Generic;

namespace LB4
{
    class Program
    {
        string[] alf = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            Program p = new Program();
            int s_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите систему счисления: ");
            int s = Convert.ToInt32(Console.ReadLine());
            while (s > 36)
            {
                Console.WriteLine();
                Console.WriteLine("Система счисления не должна превышать 36!");
                Console.WriteLine();
                Console.Write("Введите систему счисления: ");
                s = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Результат: {p.WorkProgram(s_num, s)}");
            List<int> list_i = new List<int>();
            for (int i = 2; i < 37; i++)
            {
                string str = p.WorkProgram(23, i);
                if (str[str.Length-1] == '2')
                {
                    list_i.Add(i);
                }
            }
            string exp_str = "";
            for (int i = 0; i < list_i.Count; i++)
            {
                if (i+1<list_i.Count)
                {
                    exp_str += $"{list_i[i]}, ";
                }
                else
                    exp_str += list_i[i];
            }
            Console.Write("Cистемы счисления, в которых запись числа 23 оканчивается на 2: " + exp_str);
            Console.ReadKey();
        }
        public string WorkProgram(int s_num, int s)
        {
            string f_num = "";
            Stack<int> stack = new Stack<int>();
            while (s_num > 0)
            {
                int x = s_num % s;
                stack.Push(x);
                s_num /= s;
            }
            while (stack.Count > 0)
            {
                string x = "";
                if (stack.Peek() >= 10)
                {
                    int o = stack.Pop() % 10;
                    x = alf[o];
                }
                else
                    x = $"{stack.Pop()}";
                f_num += x;
            }
            return f_num;
        }
    }
}
