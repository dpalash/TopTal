using System;
using System.Linq;

namespace TopTal.Algorithms
{
    public static class SmallInArray
    {
        public static int solution(int[] A)
        {
            int smallestNumber = 1;

            if (A == null || A.Length <= 0)
                return smallestNumber;

            if (A.All(x => x < 0))
                return smallestNumber;

            if (A.Any(x => x < 0))
            {
                A = A.Where(x => x > 0).ToArray();
            }

            A = A.Distinct().ToArray();
            Array.Sort(A);

            if (A[0] - 1 >= 1 && !A.Contains(A[0] - 1))
            {
                return smallestNumber;
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (!A.Contains(A[i] + 1))
                {
                    smallestNumber = A[i] + 1;
                    break;
                }
            }

            return smallestNumber;
        }
    }
}
