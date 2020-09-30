using System;

namespace Codility
{
    public class ArrayProblems
    {
        public ArrayProblems()
        {

        }

        public int[] Rotate(int[] A, int K)
        {
            // Perform K rotations on input

            if (A == null || A.Length == 0 )
            {
                return A;
            }

            int k = K % A.Length;

            if ( A.Length == k)
            {
                return A;
            }


            int[] output = new int[A.Length];


            for (int i = 0; i < (A.Length - k); i++)
            {
                output[i + k] = A[i];
            }

            int lastA = A.Length;


            for (int i = 0; i < k; i++)
            {
                output[i] = A[lastA - (k - i)];
            }

            return output;


        }
    }
}
