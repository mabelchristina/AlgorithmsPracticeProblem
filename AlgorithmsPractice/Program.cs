using System;
using System.IO;

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
                Console.WriteLine("choose 1.PermutationOfString 2. Binary Search");
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
                    case 2:
                        string filepath = @"D:\my git\AlgorithmsPracticeProblem\AlgorithmsPractice\Words.txt";
                        string text = File.ReadAllText(filepath);
                        string[] textArray = text.Split(" ");
                        BinarySearch binarySearch = new BinarySearch(textArray);
                        Console.WriteLine("Enter a word to search:");
                        string word = Console.ReadLine();
                        int found = binarySearch.FindWord(word, 0, textArray.Length - 1);
                        if (found == 1)
                        {
                            Console.WriteLine("The word {0} is found", word);
                        }
                        else
                        {
                            Console.WriteLine("the word {0} is not found", word);
                        }
                        break;

                    default:
                        Console.WriteLine("Exit");
                        break;
                }
            }
        }
            }
        }

