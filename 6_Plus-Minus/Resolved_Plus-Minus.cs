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
        float positives = 0;
        float negatives = 0;
        float zeros = 0;
        
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
        
        int longArray = arr.Count;
        
        Console.Out.WriteLine((positives/longArray).ToString("0.000000"));
        Console.Out.WriteLine((negatives/longArray).ToString("0.000000"));
        Console.Out.WriteLine((zeros/longArray).ToString("0.000000"));

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