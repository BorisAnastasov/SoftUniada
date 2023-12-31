﻿using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System;
using System.Collections.Generic;
namespace _04._Stars_in_the_Cube
{
       internal class Program
       {
              static void Main(string[] args)
              {
                     int n = int.Parse(Console.ReadLine());
                     if (n < 3)
                     {
                            Console.WriteLine(0);
                            return;
                     }

                     char[,,] matrix = new char[n, n, n];

                     Dictionary<char, int> dict = new Dictionary<char, int>();

                     for (int i = 0; i < n; i++)
                     {
                            string[] arr = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.None).ToArray();
                            for (int z = 0; z < n; z++)
                            {
                                   char[] ch = arr[z].Split(new string[] { " " }, StringSplitOptions.None).Select(char.Parse).ToArray();
                                   for (int o = 0; o < n; o++)
                                   {
                                          matrix[i, z, o] = ch[o];
                                   }
                            }
                     }

                     for (int row = 1; row < matrix.GetLength(0) - 1; row++)
                     {
                            for (int col = 1; col < matrix.GetLength(1) - 1; col++)
                            {
                                   for (int lay = 1; lay < matrix.GetLength(2) - 1; lay++)
                                   {
                                          char currVal = matrix[row, col, lay];
                                          if (CheckingCell(matrix, row, col, lay))
                                          {
                                                 if (dict.ContainsKey(currVal))
                                                 {
                                                        dict[currVal]++;

                                                 }
                                                 else
                                                 {
                                                        dict.Add(currVal, 1);
                                                 }
                                          }
                                   }
                            }
                     }
                     StringBuilder sb = new StringBuilder();
                     int sum = 0;
                     foreach (char key in dict.Keys.OrderBy(x => x))
                     {
                            sb.AppendLine($"{key} -> {dict[key]}");
                            sum += dict[key];
                     }
                     Console.WriteLine(sum);
                     Console.WriteLine(sb.ToString());
              }


              public static bool CheckingCell(char[,,] matrix, int row, int col, int layer)
              {
                     char currVal = matrix[row, col, layer];

                     return matrix[row - 1, col, layer] == currVal && matrix[row + 1, col, layer] == currVal &&

                     matrix[row, col - 1, layer] == currVal && matrix[row, col + 1, layer] == currVal &&

                     matrix[row, col, layer - 1] == currVal && matrix[row, col, layer + 1] == currVal;
              }


       }
}