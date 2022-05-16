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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string AMPM = "";
        string hora = "";
        string HoraFinal = "";

        AMPM = s.Substring(s.Length - 2, 2);
        hora = s.Substring(0, 2);

        //Console.WriteLine(AMPM);

        string HoraSinAMPM = s.Remove(s.Length - 2, 2);
        if (AMPM == "PM")
        {
            if (hora != "12")
            {
                HoraFinal = (Convert.ToInt32(hora) + 12).ToString() + HoraSinAMPM.Remove(0, 2);
            }
            else
            {
                HoraFinal = HoraSinAMPM;
            }
        }
        else
        {

            if (hora == "12")
            {
                HoraFinal = "00" + HoraSinAMPM.Remove(0, 2);
            }
            else
            {
                HoraFinal = HoraSinAMPM;
            }

        }

        return HoraFinal;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
