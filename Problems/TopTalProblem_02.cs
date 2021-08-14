using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TopTal.Problems
{
    public static class TopTalProblem_02
    {
        public static string solution(string S)
        {
            if (string.IsNullOrWhiteSpace(S))
                return string.Empty;

            var formattedPhoneNumber = string.Empty;

            var onlyDigits = S.Where(char.IsDigit).ToArray();

            if (!S.Contains("--"))
            {
                for (int i = 0; i < onlyDigits.Length; i++)
                {
                    if (i != 0 && i % 3 == 0)
                    {
                        formattedPhoneNumber += "-";
                    }

                    formattedPhoneNumber += onlyDigits[i];
                }
            }
            else
            {
                int i;
                for (i = 0; i < onlyDigits.Length - 4; i++)
                {
                    if (i != 0 && i % 3 == 0)
                    {
                        formattedPhoneNumber += "-";
                    }

                    formattedPhoneNumber += onlyDigits[i];
                }

                formattedPhoneNumber += "-";

                int j = i;
                for (j = i; j < onlyDigits.Length; j++)
                {
                    if (j != i && j% 2 == 0)
                    {
                        formattedPhoneNumber += "-";
                    }

                    formattedPhoneNumber += onlyDigits[j];
                }
            }

            return formattedPhoneNumber;
        }
    }
}
