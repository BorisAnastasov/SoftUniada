using System;
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

              public static void ParsingToTime(string input)
              {
                     string pattern = @"(?<days>\d*):?:?(?<hours>\d*):(?<minutes>\d*)";
                     Match m = Regex.Match(input, pattern);

                     if (input) { }
              }
       }
}