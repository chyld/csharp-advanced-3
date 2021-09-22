using System;
using AppLibrary;

namespace MainApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Rectangle r1 = new() { Name = "Rekky", Length = 3, Width = 5 };
      Console.WriteLine($"{r1}");
    }
  }
}
