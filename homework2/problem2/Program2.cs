using System;

namespace problem2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int[] a;

            Console.WriteLine("请输入数组的长度：");
            int len = Convert.ToInt32(Console.ReadLine());
            a = new int[len];

            Console.WriteLine("请输入数组包含的整数：");
            for (int i = 0; i < len; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("请输入操作数，选择对数组进行的操作：");
                Console.WriteLine("1、求最大值       2、求最小值");
                Console.WriteLine("3、求平均值       4、求和");
                char op = Convert.ToChar(Console.ReadLine());

                switch (op)
                {
                    case '1':
                        Console.WriteLine(Max(a));
                        break;
                    case '2':
                        Console.WriteLine(Min(a));
                        break;
                    case '3':
                        Console.WriteLine(Avg(a));
                        break;
                    case '4':
                        Console.WriteLine(Sum(a));
                        break;
                    default:
                        Console.WriteLine("请输入正确的操作数！");
                        break;
                }
                Console.WriteLine("输入q退出程序，输入其他继续");
            }
            while (Console.ReadLine() != "q");


            static int Max(int[] a)
            {
                int max = a[0];
                foreach (int num in a)
                    if (num > max)
                        max = num;

                return max;
            }

            static int Min(int[] a)
            {
                int max = a[0];
                foreach (int num in a)
                    if (num < max)
                        max = num;

                return max;
            }

            static double Avg(int[] a)
            {
                double sum = 0;
                foreach (int num in a)
                    sum += num;

                return sum / a.Length;
            }

            static int Sum(int[] a)
            {
                int sum = 0;
                foreach (int num in a)
                    sum += num;

                return sum;
            }
        }
    }
}
