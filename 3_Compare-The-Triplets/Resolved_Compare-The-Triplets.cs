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

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> alice = new List<int>(a);
        List<int> bob = new List<int>(b);
        int pointsOfAlice = 0;
        int pointsOfBob = 0;
        
        for (var i = 0; i < a.Count; i++) {
            
            if(a[i] > b[i]){
                pointsOfAlice++;
            }    
            else if(a[i] < b[i]){
            pointsOfBob++;
            }
        }
        
        List<int> result = new List<int>();
        result.Add(pointsOfAlice);
        result.Add(pointsOfBob);
        
         
        return result;
    }    

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
