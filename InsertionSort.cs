using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'insertionSort1' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static void insertionSort1(int n, List<int> arr)
    {
        int x = arr.Last();
            for (var i = arr.Count - 2; i >= 0; i--)
            {
                if (arr[i] < x){
                    arr[i + 1] = x;
                    foreach (var va in arr)
                        Console.Write($"{va} ");
                    break;
                }   
                else if (i == 0)
                {
                    arr[i + 1] = arr[i];
                    foreach (var va in arr)
                        Console.Write($"{va} ");
                    Console.WriteLine();
                    arr[i] = x;
                    foreach (var va in arr)
                        Console.Write($"{va} ");
                    break;
                }
                else
                    arr[i + 1] = arr[i];

                foreach (var va in arr)
                    Console.Write($"{va} ");
                Console.WriteLine();
            }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.insertionSort1(n, arr);
    }
}
