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
    public static void plusMinus(List<int> arr)
    {
        long positives = 0;
        long negatives = 0;
        long zeros = 0;
        
        for(var i = 0; i < arr.Count; i++) {
            if(arr[i] > 0)
            {
                positives++;
            } else if (arr[i] == 0)
            {
                zeros++;
            } else
            {
               negatives++;
            }  
        }
        
        long longArray = arr.Count;
        
        Console.Out.WriteLine((positives/arr.Count).ToString("0.00"));
        Console.Out.WriteLine((negatives/longArray).ToString("0.00"));
        Console.Out.WriteLine((zeros/longArray).ToString("0.00"));

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
