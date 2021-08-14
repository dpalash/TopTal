using System;
using System.Collections.Generic;
using System.Linq;

namespace TopTal.Problems
{
    public static class TopTalProblem_01
    {
        public static string solution(string[] A, string[] B, string P)
        {
            if (string.IsNullOrWhiteSpace(P))
                return string.Empty;

            if (A == null || A.Length <= 0)
                return null;

            if (B == null || B.Length <= 0)
                return null;

            Dictionary<int, string> resultantList = new Dictionary<int, string>();

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i].Contains(P))
                {
                    resultantList.Add(i, A[i]);
                }
            }

            if (resultantList.Count == 0)
                return "NO CONTACT";

            var outputKey = resultantList.OrderBy(x => x.Value).FirstOrDefault();

            return A[outputKey.Key];
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//// you can also use other imports, for example:
//// using System.Collections.Generic;

//// you can write to stdout for debugging purposes, e.g.
//// Console.WriteLine("this is a debug message");

//class Solution
//{
//    public string solution(string[] A, string[] B, string P)
//    {
//        if (string.IsNullOrWhiteSpace(P))
//            return string.Empty;

//        if (A == null || A.Length <= 0)
//            return null;

//        if (B == null || B.Length <= 0)
//            return null;

//        Dictionary<int, string> resultantList = new Dictionary<int, string>();

//        for (int i = 0; i < B.Length; i++)
//        {
//            if (B[i].Contains(P))
//            {
//                resultantList.Add(i, A[i]);
//            }
//        }

//        if (resultantList.Count == 0)
//            return "NO CONTACT";

//        var outputKey = resultantList.OrderBy(x => x.Value).FirstOrDefault();

//        return A[outputKey.Key];
//    }
//}
