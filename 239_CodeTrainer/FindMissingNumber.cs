using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System;

// Do not change the class name
public class FindMissingNumber
{

    // COMPLETE THIS FUNCTION
    public static string process(string[] arr, int size)
    {
        Console.WriteLine(string.Join("\n", arr));

        return "";
    }

    // you do not need to edit anything below this line.
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split(' ');

        process(arr, arr.Length);
    }
}