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
          //演算子
          base1();
          break;
        case 2:
          //制御文
          base2();
          break;
        case 3:
          //繰り返し
          base3();
          break;
        case 4:
          //その他の制御文
          base4();
          break;
        default:
          break;
      }
    }

    // 演算子
    private static void base1()
    {
      int a = 1;
      int b = 1;
      int c = a + b;

      System.Console.Out.WriteLine(c);

      bool equal = a == b;

      System.Console.Out.WriteLine(equal);

      bool check1 = (a == b) && (c == 1);
      bool check2 = (a == b) || (c == 1);

      System.Console.Out.WriteLine(check1);
      System.Console.Out.WriteLine(check2);

      int d = 1;
      d += 1; // d = d + 1

      System.Console.Out.WriteLine(d);

      int e = 1;
      e++; // e = e + 1

      System.Console.Out.WriteLine(e);
    }

    // 制御文
    private static void base2()
    {
      bool eat = false;

      if (eat == true)
      {
        System.Console.Out.WriteLine("今日はごはんを食べました。");
      }
      else
      {
        System.Console.Out.WriteLine("今日はごはんを食べていません。");
      }


      string weather = "雨";

      if (weather == "晴れ")
      {
        System.Console.Out.WriteLine("今日は晴れです。");
      }
      else if (weather == "曇り")
      {
        System.Console.Out.WriteLine("今日は曇りです。");
      }
      else
      {
        System.Console.Out.WriteLine("今日は雨です。");
      }
    }

    // 繰り返し
    private static void base3()
    {
      bool hit = false;
      string[] box = { "はずれ", "はずれ", "はずれ", "あたり", "はずれ" };
      int count = 0;
      while (hit == false)
      {
        if (box[count] == "あたり")
        {
          hit = true;
        }
        System.Console.Out.WriteLine(box[count]);
        count++;
      }

      hit = false;
      count = 0;
      do
      {
        if (box[count] == "あたり")
        {
          hit = true;
        }
        System.Console.Out.WriteLine(box[count]);
        count++;
      } while (hit == false);

      for (int i = 0; i < 5; i++)
      {
        System.Console.Out.WriteLine(box[i]);
      }

      for (int i = 0; i < 5; i++)
      {
        for (int j = 0; j < 5; j++)
        {
          System.Console.Out.Write("*");
        }
        System.Console.Out.WriteLine();
      }
    }

    // その他の制御文
    private static void base4()
    {
      for (int j = 0; j < 5; j++)
      {
        System.Console.Out.Write("*");
        break;
      }

      for (int j = 0; j < 5; j++)
      {
        continue;
        System.Console.Out.Write("*");
      }
    }
  }
}
