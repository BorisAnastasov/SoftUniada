using System;
using System.Text;

namespace _02._Draw_a_House
{
       internal class Program
       {
              static void Main(string[] args)
              {
                     int n = int.Parse(Console.ReadLine());

                     StringBuilder sb = new();


                     // roof
                     sb.AppendLine(CreatitingRoof(n, 2 * n - 1));
                     sb.AppendLine(CreatitingBlock(n, 2 * n - 1));

                     Console.WriteLine(sb.ToString());
              }

              static string CreatitingRoof(int rows, int cols)
              {
                     StringBuilder sb = new();

                     //making each floor
                     int count = 0;
                     for (int i = 0; i < rows - 1; i++)
                     {
                            sb.Append(new string('.', rows - count - 1));
                            sb.Append("*");
                            if (count != 0)
                            {
                                   sb.Append(new string(' ', 2*count-1));
                                   sb.Append("*");
                            }
                            sb.AppendLine(new string('.', rows - count - 1));
                            count++;
                     }
                     char[] arr = new string('*', rows).ToCharArray();
                     sb.Append(string.Join(" ", arr));

                     return sb.ToString();
              }
              static string CreatitingBlock(int rows, int cols)
              {
                     StringBuilder sb = new();

                     sb.AppendLine("+" + new string('-', cols - 2) + '+');

                     //making each floor
                     for (int i = 0; i < rows-2; i++)
                     {
                            sb.AppendLine('|' + new string(' ', cols-2) +'|');
                     }
                     sb.AppendLine("+" + new string('-', cols - 2) + '+');

                     return sb.ToString();
              }
       }
}