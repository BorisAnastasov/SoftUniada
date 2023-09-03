using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Sum_Time
{
       internal class Program
       {
              static void Main(string[] args)
              {
                     string inputOne = Console.ReadLine();
                     string inputTwo = Console.ReadLine();

                     int sum = ParsingTimeIntoMinutes(inputOne) + ParsingTimeIntoMinutes(inputTwo);

                     Console.WriteLine(ConvertingToClock(sum));
              }

              static int ParsingTimeIntoMinutes(string input)
              {
                     int[] arr = input.Split(':').Where(s=>s.Length>0).Select(int.Parse).ToArray();
                     int sum = 0;
                     if (arr.Length == 3)
                     {
                            sum += arr[0] * 1440;
                            sum += arr[2] + arr[1] * 60;

                     }
                     else
                     {
                            sum += arr[1] + arr[0] * 60;
                     }

                     return sum;
              }

              static string ConvertingToClock(int min)
              {
                     int days = min / 1440;
                     min %= 1440;

                     int hours = min / 60;
                     min %= 60;

                     int minutes = min;

                     if (days > 0)
                     {
                            return $"{days}::{hours}:{minutes:D2}";
                     }
                     else
                     {
                            return $"{hours}:{minutes:D2}";
                     }
              }
       }
}