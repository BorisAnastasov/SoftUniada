﻿using System;
using System.Text.RegularExpressions;
namespace _03._Sum_Time
{
       internal class Program
       {
              static void Main(string[] args)
              {
                     string inputOne = Console.ReadLine();
                     string inputTwo = Console.ReadLine();


              }

              public static int ParsingToMinutes(string input)
              {
                     string pattern = @"(?<days>\d*):?:?(?<hours>\d*):(?<minutes>\d*)";
                     string patternDays = @"^()";
                     string patternHours = @"(?<days>\d*):?:?(?<hours>\d*):(?<minutes>\d*)";
                     string patternMinutes = @"(?<days>\d*):?:?(?<hours>\d*):(?<minutes>\d*)";
                     Match m = Regex.Match(input, pattern);
                     int minutes = 0;
                     if (m.Groups["days"].Success)
                     {
                            int days = Regex.Match(m.Groups["days"], patternDays)
                            minutes += 
                     }
                     //hours
                     int hours = Regex.Match(m.Groups["days"], patternDays)
                     minutes += hours * 60;

                     //minutes  
                     minutes += int.Parse(m.Groups["minutes"]);
              }
       }
}