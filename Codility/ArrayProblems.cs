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
            // Perform K rotations to the right on input

            // The easy ones
            if (A == null || A.Length == 0 )
            {
                return A;
            }

            // Only need to rotate what's left after a full rotation
            int k = K % A.Length;
            if ( A.Length == k)
            {
                return A;
            }

            // Only grow by k
            int[] backK = new int[k];

            int last = A.Length - k;

            // Save the last k elements
            for (int i = 0; i < k; i++)
            {
                backK[i] = A[last + i];
            }

            // Shift by k
            for (int i = 0; (i + k) < A.Length ; i++)
            {
                A[i + k] = A[i];
            }

            // Insert the saved k elements at the front
            for (int i = 0; i < k; i++)
            {
                A[i] = backK[i];
            }

            return A;
        }

        public int OddManOut(int[] A)
        {
            int oddnum = 0;

            // Super efficient solution 
            //for (int i = 0; i < A.Length; i++)
            //{
            //    oddnum ^= A[i];
            //}


            // My solution
            Array.Sort(A);

            for (int i = 0; i < A.Length; i += 2)
            {
                if (i + 1 == A.Length || A[i] != A[i + 1])
                {
                    oddnum = A[i];
                    break;
                }
            }

            return oddnum;
        }
    }
}
