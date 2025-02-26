using System;
using System.Collections;
using System.Collections.Generic;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(4.5);
            arrayList.Add(18);

            List<int> newCollection = new List<int> { 5, 6, 7, 8, 9 };

            int n1 = int.Parse(Console.ReadLine());

            arrayList.InsertRange(n1, newCollection);


            int n = n1 / 2;
            int k = int.Parse(Console.ReadLine());

            if (n < arrayList.Count)
            {
                int removeCount = Math.Min(k, arrayList.Count - n);
                arrayList.RemoveRange(n, removeCount);
            }
        }
    }
}
