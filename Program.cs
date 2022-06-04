using System;

namespace Algoritms_MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort s = new Sort();
            
            int n = 10;
            for (int i = 0; i < 6; i++)
            {
                n = n * 10;

                TimeTest.Test(n, s.MergeSort, "MergeSort");

            }
        }
    }
}
