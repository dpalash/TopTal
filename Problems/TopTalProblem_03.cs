using System;
using System.Collections.Generic;
using System.Linq;

namespace TopTal.Problems
{
    public static class TopTalProblem_03
    {
        public static int solution(int Y, string A, string B, string W)
        {
            int weeksNumber = 0;

            var getDayMonthCollection = GetDayMonthCollection();

            var start = getDayMonthCollection.FirstOrDefault(x => x.NameOfMonth == A);
            var end = getDayMonthCollection.FirstOrDefault(x => x.NameOfMonth == B);

            var months = getDayMonthCollection.Where(x => x.monthIndex >= start.monthIndex && x.monthIndex <= end.monthIndex).ToList();

            DateTime startDateTemp = DateTime.Now;
            foreach (var item in months)
            {
                DateTime startDate = startDateTemp = new DateTime(Y, item.monthIndex, 1);
                weeksNumber = weeksNumber + GetWeekEnds(startDate);

                if (startDate.DayOfWeek.ToString() != W)
                    weeksNumber = weeksNumber - 1;
            }

            if (startDateTemp.DayOfWeek.ToString() != W)
                weeksNumber = weeksNumber - 1;

            return weeksNumber;
        }

        private static int GetWeekEnds(DateTime date)
        {
            // first generate all dates in the month of 'date'
            var dates = Enumerable.Range(1, DateTime.DaysInMonth(date.Year, date.Month)).Select(n => new DateTime(date.Year, date.Month, n));

            // then filter the only the start of weeks
            var weekends = from d in dates
                           where d.DayOfWeek == DayOfWeek.Monday
                           select d;

            return weekends.Count();
        }

        public static List<DayMonth> GetDayMonthCollection()
        {
            List<DayMonth> dayMonth = new List<DayMonth>
            {
                new DayMonth {monthIndex=1, NoOfDays = 31, NameOfMonth = "January"},
                new DayMonth {monthIndex=2, NoOfDays = 28, NameOfMonth = "February"},
                new DayMonth {monthIndex=3, NoOfDays = 31, NameOfMonth = "March"},
                new DayMonth {monthIndex=4, NoOfDays = 30, NameOfMonth = "April"},
                new DayMonth {monthIndex=5, NoOfDays = 31, NameOfMonth = "May"},
                new DayMonth {monthIndex=6, NoOfDays = 30, NameOfMonth = "June"},
                new DayMonth {monthIndex=7, NoOfDays = 31, NameOfMonth = "July"},
                new DayMonth {monthIndex=8, NoOfDays = 31, NameOfMonth = "August"},
                new DayMonth {monthIndex=9, NoOfDays = 30, NameOfMonth = "September"},
                new DayMonth {monthIndex=10, NoOfDays = 31, NameOfMonth = "October"},
                new DayMonth {monthIndex=11, NoOfDays = 30, NameOfMonth = "November"},
                new DayMonth {monthIndex=12, NoOfDays = 31, NameOfMonth = "December"}
            };

            return dayMonth;
        }

        public class DayMonth
        {
            public int monthIndex;
            public int NoOfDays;
            public string NameOfMonth;
        }

    }
}
