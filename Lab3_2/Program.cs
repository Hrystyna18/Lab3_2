using System;
using System.IO;

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StreamWriter file = File.CreateText("file.txt");
            for (int i = 1; i <= n; ++i)
            {
                file.Write("{0} ", 2 * i);
            }
            file.Close();
        }
    }
}
