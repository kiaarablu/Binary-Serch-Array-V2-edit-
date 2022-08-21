using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Binary_Serch_Array_V2_edit_
{
    public class Binary
    {
        int[] arr = new int[] { 10, 22, 32, 43, 53, 65, 73, 81 };
        int first;
        int last;
        int middle;

        public Binary()
        {
            last = arr.Length - 1;
            first = 0;
            middle = (first + last) / 2;
        }

        public void BinarySearchs(int key)
        {
            while (true)
            {
                if (key == arr[middle])
                {
                    Console.WriteLine(middle);
                    return;
                }
                else if (last == first)
                {
                    Console.WriteLine("Item Not Found!");
                    return;
                }
                else if (key > arr[middle])
                {
                    first = middle + 1;
                    middle = (first + last) / 2;
                }
                else
                {
                    last = middle - 1;
                    middle = (first + last) / 2;
                }
            }
        }
    }
}