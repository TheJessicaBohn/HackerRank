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

    public static void staircase(int n)
    {
        int sizeSteps = n - 1;
        
        for(int i = 0; i < n; i++) {
            StringBuilder result = new StringBuilder();
            for(int j = 0; j < sizeSteps; j++) {
                result.Append(" ");
            }
            for(int l = 0; l < n - sizeSteps; l ++){
                result.Append("#");
            }
            
            sizeSteps -= 1;
            Console.Out.WriteLine(result);
        }

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
