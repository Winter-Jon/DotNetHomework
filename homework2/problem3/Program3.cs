using System;

namespace problem3
{
    class Program3
    {
        static void Main(string[] args)
        {
            int[] a = new int[99];

            for(int i=0;i<99;i++)
                a[i] = i+2;

            int pt = 0;
            do
            {
                a=Remove(a, a[pt]);
                pt++;
            }
            while (a.Length!= Remove(a, a[pt]).Length);

            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]); 

        }

        static int[] Remove(int[] a,int n)
        {
            int len=a.Length;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%n==0&&a[i]!=n)
                {
                    a[i] = 0;
                    len--;
                }
            }

            int[] b = new int[len];
            int num = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]!=0)
                {
                    b[num] = a[i];
                    num++;
                }
            }
            return b;
        }



    }
}
