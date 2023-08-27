using System;
using System.Text;

namespace _02._Draw_a_House
{
       internal class Program
       {
              static void Main(string[] args)
              {
                     int n = int.Parse(Console.ReadLine());

                     string result = CreatitingRoof(n, 2 * n - 1) + "\n" + CreatitingBlock(n, 2 * n - 1);

                     Console.WriteLine(result);
              }

              static string CreatitingRoof(int rows, int cols)
              {
                     string result = "";

                     //making each floor
                     int count = 0;
                     for (int i = 0; i < rows - 1; i++)
                     {
                            result += new string('.', rows - count - 1);
                            if (count == 0)
                            {
                                   result += "*";
                            }
                            else
                            {
                                   result += "*";
                                   result += new string(' ', 2*count-1);
                                   result += "*";
                            }
                            result += new string('.', rows - count - 1);
                            result += "\n";
                            count++;
                     }
                     char[] arr = new string('*', rows).ToCharArray();
                     result += string.Join(" ", arr);

                     return result;
              }

              static string CreatitingBlock(int rows, int cols)
              {
                     string result = "";

                     result += "+" + new string('-', cols - 2) + '+';
                     result += "\n";
                     //making each floor
                     for (int i = 0; i < rows-2; i++)
                     {
                            result += '|' + new string(' ', cols-2) +'|';
                            result += "\n";

                     }
                     result += "+" + new string('-', cols - 2) + '+';

                     return result;
              }
       }
}