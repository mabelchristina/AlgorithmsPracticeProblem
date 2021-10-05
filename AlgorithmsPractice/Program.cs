using System;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int options;
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("choose 1.PermutationOfString ");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("enter a string");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        Permutation.Permute(str, 0, n - 1);
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}

