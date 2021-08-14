using System;
using System.Linq;

namespace TopTal.Algorithms
{
    public static class ArrayRotation
    {
        public static int[] solution(int[] A, int K)
        {
            if (A == null || A.Length <= 0)
                return null;

            for (int i = 0; i < K; i++)
            {
                var lastElement = A[A.Length - 1];

                for (int j = A.Length - 1; j > 0; j--)
                {
                    A[j] = A[j - 1];
                }

                A[0] = lastElement;
            }

            return A;
        }
    }
}
