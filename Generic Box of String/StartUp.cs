using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
 namespace GenericBoxOfInteger
{
  public  class StartUp
    {
     public   static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> list = new List<Box<int>>();
            for (int i = 0; i < n; i++)
            {
                var input =int.Parse(Console.ReadLine());
                Box<int> current = new Box<int>(input);

                list.Add(current);
                
            }
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SwapByIndex<Box<int>>(list, indexes[0], indexes[1]);

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
     static   public List<T> SwapByIndex<T>(List<T> list, int item1, int item2)
        {
            var currentIndex = list[item1];
            list[item1] = list[item2];
            list[item2] = currentIndex;
            return list;
        }
    }
}
