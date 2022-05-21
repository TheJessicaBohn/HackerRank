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

    public static int diagonalDifference(List<List<int>> arr)
    {
        int sumLetfToRight = 0;
        int sumRightToLeft = 0;
        
        for(var i = 0; i < arr.Count; i++){
            sumLetfToRight =  sumLetfToRight + arr[i][i];
            sumRightToLeft =  sumRightToLeft + arr[arr.Count -1 -i][i];
        }
        
        int absoluteDifference = Math.Abs(sumLetfToRight - sumRightToLeft);
       
        return absoluteDifference;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
