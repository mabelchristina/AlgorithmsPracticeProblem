using System;
using System.IO;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            while (!isExit)
            {
                string filepath = @"D:\my git\AlgorithmsPracticeProblem\AlgorithmsPractice\Words.txt";
                string text = File.ReadAllText(filepath);
                string[] textArray = text.Split(" ");
                Console.WriteLine("1.Permutation of string\n2.Binary Search\n3.Insertion Sort\n4.Bubble Sort\n5.Merge Sort\n6.Anagram\n7.Prime Range");
                Console.Write("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        String str = "ABC";
                        int n = str.Length;
                        Permutation.Permute(str, 0, n - 1);
                        break;
                    case 2:

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
                    case 3:

                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.Sort(textArray);
                        insertionSort.Display(textArray);
                        break;
                    case 4:
                        int[] arr = { 77, 7, 17, 34, 56, 12, 68 };
                        BubbleSort bubbleSort = new BubbleSort();
                        arr = bubbleSort.Sort(arr);
                        bubbleSort.Display(arr);
                        break;
                    case 5:
                        MergeSort merge = new MergeSort ();
                        merge.Sort(textArray, 0, textArray.Length - 1);
                        Console.WriteLine("\nSorted array");
                        merge.PrintArray(textArray);
                        break;
                    case 6:
                        Anagram anagram = new Anagram();
                        anagram.CheckAnagram("abcd", "dcbasd");
                        break;
                    default:
                        Console.WriteLine("Exit");
                        break;
                }
            }
        }
            }
        }

