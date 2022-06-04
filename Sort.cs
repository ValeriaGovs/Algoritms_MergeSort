using System;

namespace Algoritms_MergeSort
{
    internal class Sort
    {
        int[] _mass;
        public void MergeSort(int[] mass)
        {
            _mass = mass;

            Sort(0, mass.Length - 1);

            void Sort(int L, int R)
            {
                if (L >= R) return;
                int M = (L + R) / 2;
                Sort(L, M);
                Sort(M + 1, R);
                MergeSort(L, M, R);
            }

            /*
            foreach (int i in _mass)
                Console.Write($"{_mass[i]} ");
            Console.WriteLine($"");
            */
        }


        private void MergeSort(int L, int X, int R)
        {
            int[] M = new int[R - L + 1];
            int a = L;
            int b = X + 1;
            int m = 0;
            while (a <= X && b <= R)
                if (_mass[a] < _mass[b])
                    M[m++] = _mass[a++];
                else
                    M[m++] = _mass[b++];
            while (a <= X)
                M[m++] = _mass[a++];
            while (b <= R)
                M[m++] = _mass[b++];
            for (int i = L; i <= R; i++)
                _mass[i] = M[i - L];
        }
    }
}