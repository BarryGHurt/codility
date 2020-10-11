using System;
namespace Codility
{
    public class TimeComplexity
    {
        public TimeComplexity()
        {

        }

        public int PermMissingElement(int[] A)
        {
            // Find the missing element in a given permutation.
            int result = 0;

            switch (A.Length)
            {
                case 0:
                    result = 1;
                    break;
                case 1:
                    result = A[0] == 1 ? 2 : A[0] - 1;
                    break;
                default:
                    Array.Sort(A);

                    if (A[0] > 1)
                    {
                        result = 1;
                        break;
                    }

                    for (int i = 0; i < A.Length; i++)
                    {
                        if (i + 1 == A.Length || A[i + 1] - A[i] == 2)
                        {
                            result = A[i] + 1;
                            break;
                        }
                    }
                    break;
            }

            return result;
        }
    }
}
