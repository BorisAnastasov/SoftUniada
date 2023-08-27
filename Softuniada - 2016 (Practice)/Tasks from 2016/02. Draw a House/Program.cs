using System;
using System.Text;

namespace _02._Draw_a_House
{
       internal class Program
       {
              static void Main(string[] args)
              {
                     int n = int.Parse(Console.ReadLine());

                     string result = "";
                     //roof
                     int count = 0;
                     for (int i = 0; i < n - 1; i++)
                     {
                            result += new string('.', n - count - 1);
                            if (count == 0)
                            {
                                   result += "*";
                            }
                            else
                            {
                                   result += "*";
                                   result += new string(' ', 2 * count - 1);
                                   result += "*";
                            }
                            result += new string('.', n - count - 1);
                            result += "\n";
                            count++;
                     }
                     for (int i = 0; i < n; i++)
                     {
                            result += "*";
                            if (i != n - 1)
                            {
                                   result += " ";
                            }
                     }
                     result += "\n";
                     //block
                     int cols = 2 * n - 1;
                     result += "+" + new string('-', cols - 2) + '+';
                     result += "\n";
                     //making each floor
                     for (int i = 0; i < n - 2; i++)
                     {
                            result += '|' + new string(' ', cols - 2) + '|';
                            result += "\n";

                     }
                     result += "+" + new string('-', cols - 2) + '+';

                     Console.WriteLine(result);
              }
       }
}