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

    public static void miniMaxSum(List<int> arr)
    {
        long minSum = arr.Sum(item => (long)item) - arr.Max();
        long maxSum = arr.Sum(item => (long)item) - arr.Min();
     
        StringBuilder sums = new StringBuilder();
        sums.Append(minSum).Append(" ").Append(maxSum);

        Console.WriteLine(sums);
    }
    
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
