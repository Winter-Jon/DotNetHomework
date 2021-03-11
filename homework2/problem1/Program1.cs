using System;

namespace problem1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            int a =Convert.ToInt32(Console.ReadLine());

            int[] fac = Factor(a);

            Console.WriteLine("该数的素因数有：");
            Console.WriteLine(fac[0]);
            for (int i = 1; i < fac.Length; i++)
            {
                for(int j= 0;j<=i;j++)
                {
                    if(fac[i]%fac[j]==0)
                        break;
                    else if(j>=i-1)
                        Console.WriteLine(fac[i]);
                }
            }



        }

        static int[] Factor(int a)
        {
            int[] fac;
            fac = new int[10000];
            fac[1] = 0;
            int factorNum = 0;

            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    fac[factorNum] = i;
                    factorNum++;
                }
            }

            int[] facCopy = new int[factorNum];

            for(int i=0;i<factorNum;i++)
            {
                facCopy[i] = fac[i];
            }
            return facCopy;
        }


    }
}
