using System;

namespace problem4
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入矩阵的行数：");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入矩阵的列数：");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[col,row];

            Console.WriteLine("请以矩阵形式输入整数矩阵：");
            Console.WriteLine("如：1 2 3");
            Console.WriteLine("    4 5 6");
            for (int i = 0; i < row; i++)
            {
                string str=Console.ReadLine();
                string[] strs = str.Split(" ");
                for (int j = 0; j < col; j++)
                    a[j, i] = Convert.ToInt32(strs[j]);
            }



            Console.WriteLine(Toeplitz(a));
        }

        static bool Toeplitz(int[,] a)
        {
            if(a.GetLength(0)>=a.Rank)
            {
                for(int i=0;i<= a.GetLength(0) - a.Rank;i++)
                {
                    for (int j = 0; j < a.Rank; j++)
                        if (a[j, i+j] != a[0, i])
                            return false;
                }
            }
            else
            {
                for (int i = 0; i <= a.Rank - a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(0); j++)
                        if (a[i + j, j] != a[i, 0])
                            return false;
                }
            }
            return true;

        }
    }
}
