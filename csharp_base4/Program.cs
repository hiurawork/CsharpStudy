using System.Collections.Generic;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      int input = 1;
      if (input == 1)
      {
        System.Console.Out.WriteLine("パターン1");
      }
      else if (input == 2)
      {
        System.Console.Out.WriteLine("パターン2");
      }
      else if (input == 3)
      {
        System.Console.Out.WriteLine("パターン3");
      }
      else if (input == 4)
      {
        System.Console.Out.WriteLine("パターン4");
      }
      else if (input == 5)
      {
        System.Console.Out.WriteLine("パターン5");
      }

      Dictionary<int, string> patterns = new Dictionary<int, string>(){
        {1, "パターン1"},
        {2, "パターン2"},
        {3, "パターン3"},
        {4, "パターン4"},
        {5, "パターン5"},
      };
      System.Console.Out.WriteLine(patterns[input]);
    }
  }
}
