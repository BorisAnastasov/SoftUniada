using System;
using System.Text;

namespace _02._Draw_a_House
{
       internal class Program
       {
              static void Main(string[] args)
              {
                     int n = int.Parse(Console.ReadLine());

                     StringBuilder sb = new StringBuilder();


                     // roof
                     sb.AppendLine(CreatitingRoof(n, 2 * n - 1));
                     sb.AppendLine(CreatitingBlock(n, 2 * n - 1));


              }

              static string CreatitingRoof(int rows, int cols)
              {
                     string result = "";

                     //making each floor
                     int count = 0;
                     for (int i = 0; i < rows; i++)
                     {
                            for (int z = 0; z < cols; z++)
                            {
                                   result += new string('.', rows - count);
                            }
                            if (count == 0)
                            {
                                   result += "*";
                            }
                            else{
                                   result += "*";
                                   result += new string(' ', count);
                                   result += "*";
                            }
                            for (int z = 0; z < cols; z++)
                            {
                                   result += new string('.', rows - count);
                            }
                            result += "\n";
                     }

                     return result;
              }


              static string CreatitingBlock(int rows, int cols)
              {
                     string result = "";

                     //making each floor
                     for (int i = 0; i < rows; i++)
                     {
                            for (int z = 0; z < cols; z++)
                            {

                            }
                     }

                     return result;
              }
       }
}