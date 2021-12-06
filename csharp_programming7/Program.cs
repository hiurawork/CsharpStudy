using System;
using System.Collections.Generic;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> pachimons = new List<string> {
        "ぺかちゅう",
        "どるがめ",
        "ひときゃげ",
        "ふしぎだな",
      };

      foreach (string pachimon in pachimons)
      {
        System.Console.WriteLine(pachimon);
      }

      string[] characters = null; // nullの場合
      // string[] characters = { "サトス" }; // nullじゃない場合
      string character = characters?[0];
      System.Console.WriteLine(character);
      System.Console.WriteLine(character ?? "キャラクターなし");
      System.Console.WriteLine(character == null ? "キャラクターなし" : character);
    }
  }
}
