using BinarySearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Serch_Array_V2_edit_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Key : ");
            int key = Convert.ToInt32(Console.ReadLine());

            do
            {
                RecursiveBinarySearch x = new RecursiveBinarySearch();
                x.BinarySearch(key, 0, 7);

                Console.WriteLine("-----------------------------");

                Binary a = new Binary();
                a.BinarySearchs(key);


                Console.Write("Key : ");
                key = Convert.ToInt32(Console.ReadLine());

            } while (key != -50);
        }
    }
}
