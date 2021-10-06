﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice
{
    class MergeSort 
    {
        public void Merge(string[] arr, int l, int m, int r)
        {
            // Find sizes of two arrays
            int n1 = m - l + 1;
            int n2 = r - m;
            //temp arrays
            string[] L = new string[n1];
            string[] R = new string[n2];
            int i, j;
            for (i = 0; i < n1; ++i)
            {
                L[i] = arr[l + i];
            }
            for (j = 0; j < n2; ++j)
            {
                R[j] = arr[m + 1 + j];
            }

            // Merge the temp arrays
            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i].CompareTo(R[j]) <= 0)
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public void Sort(string[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the mid value
                int m = l + (r - l) / 2;
                Sort(arr, l, m);
                Sort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }
        //Printing Sorted Array
        public void PrintArray(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
