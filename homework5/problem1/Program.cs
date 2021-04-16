using System;

namespace OrderProgram
{

    class Program
    {
        static void Main(string[] args)
        {
            string currentDirName = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirName);
            for(int i=0;i<3;i++)
                currentDirName = System.IO.Directory.GetParent(currentDirName).FullName;

            Console.WriteLine(currentDirName);
            return;


        }
    }
}
