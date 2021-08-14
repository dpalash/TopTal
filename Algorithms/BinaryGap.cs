using System;
using System.Linq;

namespace TopTal.Algorithms
{
    public static class BinaryGap
    {
        public static int Solution(int N)
        {
            var binaryNumberString = string.Empty;

            do
            {
                binaryNumberString += N % 2;

                N = N / 2;

            } while (N > 0);

            var charArray = binaryNumberString.ToCharArray();
            Array.Reverse(charArray);
            binaryNumberString = new string(charArray);

            if (!binaryNumberString.Contains("0"))
                return 0;

            if (binaryNumberString.Split('1').Length <= 2)
                return 0;

            var splits = binaryNumberString.Split('1').Where(x => !string.IsNullOrWhiteSpace(x));

            int binaryGap = 0;
            foreach (var item in splits)
            {
                if (item.Length > binaryGap)
                    binaryGap = item.Length;
            }

            return binaryGap;
        }
    }
}
