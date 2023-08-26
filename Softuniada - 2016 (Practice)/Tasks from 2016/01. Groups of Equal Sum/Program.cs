using System;

using System.Collections.Generic;


namespace _01._Groups_of_Equal_Sum
{
       internal class Program
       {
              static void Main(string[] args)
              {
                     int a = int.Parse(Console.ReadLine());
                     int b = int.Parse(Console.ReadLine());
                     int c = int.Parse(Console.ReadLine());
                     int d = int.Parse(Console.ReadLine());
                     
                     var list = new List<int>() { a, b, c, d };
                     list.Sort();

                     if (list[0] + list[3] == list[1] + list[2])
                     {
                            Console.WriteLine("Yes");
                            Console.WriteLine(list[0] + list[3]);
                     }
                     else if(list[3] == list[0] + list[1] + list[2])
                     {
                            Console.WriteLine("Yes");
                            Console.WriteLine(list[3]);
                     }
                     else
                     {
                            Console.WriteLine("No");
                     }

                     //Input
                     //3
                     //2
                     //4
                     //5

                     //Output
                     //yes
                     //7

                     //Comments
                     //3 + 4 = 5 + 2

              }
       }
}