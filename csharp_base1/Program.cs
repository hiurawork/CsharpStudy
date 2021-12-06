namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      string stringNo = args[0];
      int intNo = int.Parse(stringNo);
      switch (intNo)
      {
        case 1:
          //リテラル
          base1();
          break;
        case 2:
          //エスケープシーケンス
          base2();
          break;
        case 3:
          //変数と代入
          base3();
          break;
        case 4:
          //スコープ
          base4();
          break;
        case 5:
          //定数
          base5();
          break;
        case 6:
          //様々な型と変換
          base6();
          break;
        default:
          break;
      }
    }

    // リテラル
    private static void base1()
    {
      char charValue = 'a';
      string stringValue = "こんにちは";

      System.Console.Out.WriteLine(charValue);
      System.Console.Out.WriteLine(stringValue);
    }

    //エスケープシーケンス
    private static void base2()
    {
      string line = "\r\n";
      string stringValue1 = "こんにちは";
      string stringValue2 = "今日は晴れです";

      System.Console.Out.Write(stringValue1 + line);
      System.Console.Out.Write(stringValue2);
    }

    //変数と代入
    private static void base3()
    {
      int intValue = 10;
      string stringValue = "こんにちは。今日は" + intValue + "度です。";

      System.Console.Out.WriteLine(stringValue);
    }

    //スコープ
    private static void base4()
    {
      string scope1 = "これはbase4のスコープ";

      if (true == true)
      {
        string scope3 = "これはifのスコープ";

        System.Console.Out.WriteLine(scope1);
        System.Console.Out.WriteLine(scope3);
      }
      // System.Console.Out.WriteLine(scope3);
    }

    //定数
    private static void base5()
    {
      string stringValue = "これは変数です。";
      const string stringValueConst = "これは定数です。";

      // stringValue = "この変数は再代入されました。";
      // stringValueConst = "この定数は再代入されました。";

      System.Console.Out.WriteLine(stringValue);
      System.Console.Out.WriteLine(stringValueConst);
    }

    //様々な型と変換
    private static void base6()
    {
      string[] stringArray = { "リンゴ", "バナナ", "モモ" };

      System.Console.Out.WriteLine(stringArray[0]);
      System.Console.Out.WriteLine(stringArray[1]);
      System.Console.Out.WriteLine(stringArray[2]);

      string[] stringArray2 = new string[3];
      stringArray2[0] = "ボブ";
      stringArray2[1] = "キャサリン";
      stringArray2[2] = "田中";

      System.Console.Out.WriteLine(stringArray2[0]);
      System.Console.Out.WriteLine(stringArray2[1]);
      System.Console.Out.WriteLine(stringArray2[2]);
    }
  }
}
