using System;
using AppLibrary;

namespace MainApp
{
  class Program
  {
    static void Main(string[] args)
    {
      // calling library functions
      Rectangle r1 = new() { Name = "Rekky", Length = 3, Width = 5 };
      var data = Fetching.GetDataFromHttp().GetAwaiter().GetResult();

      // display json data
      foreach (var generic in data.Item1)
      {
        Console.WriteLine(generic);
      }

      // display csv data
      Console.WriteLine(data.Item2);

    }
  }
}
