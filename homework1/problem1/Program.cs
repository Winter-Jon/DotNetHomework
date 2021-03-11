using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个操作数：");
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个操作数：");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入操作符：");
            char oper= Convert.ToChar(Console.ReadLine());
            double s = 0;

            if (oper=='+')
            {
                s = a + b;
            }
            else if (oper == '-')
            {
                s = a - b;
            }
            else if (oper == '*')
            {
                s = a * b;
            }
            else if (oper == '/')
            {
                s = a / b;
            }
            else
            {
                Console.WriteLine("请输入正确的操作符！");
                return;
            }

            Console.WriteLine("计算结果为：");
            Console.WriteLine(s);
            return;

        }
    }
}
