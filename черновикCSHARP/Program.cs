using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

public class MainClass
{
    public static void Main()
    {
        string x = Console.ReadLine();
        string y = Console.ReadLine();
        string[] START = x.Split();
        string[] FINISH = y.Split();
        int hour = Convert.ToInt32(START[0]);
        int minute = Convert.ToInt32(START[1]);
        int hourEND = Convert.ToInt32(FINISH[0]);
        int minuteEND = Convert.ToInt32(FINISH[1]);
        int hits = 0;
        while (hour != hourEND || minute != minuteEND)
        {
            if (minute == 0)
            {
                if (hour == 0)
                {
                    hits = hits + 12;
                }
                if (hour > 0 && hour <= 12)
                {
                    hits = hits + hour;
                }
                if (hour > 12 && hour < 24)
                {
                    hits = hits + (hour - 12);
                }
            }
            if (minute == 30)
            {
                hits += 1;
            }

            minute++;

            if (minute == 60)
            {
                if (hour == 23)
                {
                    hour = 0;
                    minute = 0;
                }
                else
                {
                    hour += 1;
                    minute = 0;
                }
            }



        }
        Console.WriteLine(hits);
    }
}