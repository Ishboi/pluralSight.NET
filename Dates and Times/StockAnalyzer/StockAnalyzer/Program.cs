using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace StockAnalyzer
{
  class Program
  {
    static void Main(string[] args)
    {

      var now = DateTimeOffset.UtcNow;

      Console.WriteLine(now.ToLocalTime());

    }
  }
}
