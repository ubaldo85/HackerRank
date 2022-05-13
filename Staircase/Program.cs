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
     * Complete the 'staircase' function below.
     * Imprime una cadena asi:
     *      *
     *     **
     *    *** 
     *   ****
     * The function accepts INTEGER n as parameter.
     */

    public static void Staircase(int n)
    {
        StringBuilder gato = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            //Espacios
            for (int j = 0; j < n - i; j++)
            {
                gato.Append(" ");
            }

            for (int k = 0; k < i; k++)
            {
                gato.Append("#");
            }

            Console.WriteLine(gato);
            gato.Clear();
        }
        Console.ReadLine();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.Staircase(n);
    }
}
