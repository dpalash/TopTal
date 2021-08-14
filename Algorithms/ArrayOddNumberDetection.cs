using System;
using System.Linq;

namespace TopTal.Algorithms
{
    public static class ArrayOddNumberDetection
    {
        public static int solution(int[] A)
        {
            var distinctArrayElements = A.Distinct().ToArray();
            for (int i = 0; i < distinctArrayElements.Count(); i++)
            {
                if (A.Count(x => x == distinctArrayElements[i]) % 2 != 0)
                    return distinctArrayElements[i];
            }

            return 0;
        }
    }
}
