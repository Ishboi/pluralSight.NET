using System;
using System.Globalization;

namespace Dates_and_Times_in_.NET
{
  class Program
  {
    static Calendar calendar = CultureInfo.InvariantCulture.Calendar;
    static void Main(string[] args)
    {

      var contractDate = new DateTimeOffset(2020, 2, 29, 0, 0, 0, TimeSpan.Zero);

      Console.WriteLine(contractDate);

      contractDate = ExtendContract(contractDate, 1);
      Console.WriteLine(contractDate);


      //var start = new DateTimeOffset(2007, 12, 31, 0, 0, 0, TimeSpan.Zero);

      //var week = calendar.GetWeekOfYear(start.DateTime,
      //    CalendarWeekRule.FirstFourDayWeek,
      //    DayOfWeek.Monday);
      //Console.WriteLine(week);

      //var isoWeek = ISOWeek.GetWeekOfYear(start.DateTime);
      //Console.WriteLine(isoWeek);

      //var isoWeekHack = GetIso8601WeekOfYear(start.Date);
      //Console.WriteLine(isoWeekHack);

      //var start = DateTimeOffset.UtcNow;
      //var end = start.AddSeconds(45);

      //TimeSpan difference = end - start;

      //difference = difference.Multiply(2);

      //Console.WriteLine(difference.TotalMinutes);
    }

    public static DateTimeOffset ExtendContract(DateTimeOffset current, int months)
    {
      var newContractDate = current.AddMonths(months).AddTicks(-1);

      return new DateTimeOffset(newContractDate.Year,
          newContractDate.Month,
          DateTime.DaysInMonth(newContractDate.Year, newContractDate.Month),
          23, 59, 59, current.Offset);
    }


    // This presumes that weeks start with Monday.
    // Week 1 is the 1st week of the year with a Thursday in it.
    public static int GetIso8601WeekOfYear(DateTime time)
    {
      // Seriously cheat. If its Monday, Tuesday or Wednesday, then it'll
      // be the same week# as whatever Thursday, Friday or Saturday are,
      // and we always get those right
      DayOfWeek day = calendar.GetDayOfWeek(time);
      if(day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
      {
        time = time.AddDays(3);
      }

      // Return the week of our adjusted day
      return calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek,
        DayOfWeek.Monday);
    }


  }
}
