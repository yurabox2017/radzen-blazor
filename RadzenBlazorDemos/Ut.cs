using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Radzen.Blazor
{
    internal static class Ut
    {

        internal static bool In<T>(this T sourse, params T[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));

            return values.Contains(sourse);
        }
        public static List<DateTime> GetWorkDays(DateTime currentDate, List<int> daysOfWeek)
        {
            if (daysOfWeek is null)
                return null;

            List<DateTime> lstDays = new List<DateTime>();

            var days = daysOfWeek;

            var firstDayOfMonth = currentDate.StartOfMonth();
            var daysMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            for (int i = 0; i < daysMonth; i++)
            {
                if (days.Contains((int)firstDayOfMonth.AddDays(i).DayOfWeek))
                    lstDays.Add(firstDayOfMonth.AddDays(i));
            }

            return lstDays;
        }
        public static DateTime StartOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }
    }
}
