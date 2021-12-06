using System;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      //エラーのキャッチとファイナリー
      try
      {
        int[] test = { 1, 2, 3 };
        System.Console.WriteLine(test[4]);
      }
      catch
      {
        System.Console.WriteLine("指定された箇所に値が存在しない");
      }
      finally
      {
        System.Console.WriteLine("処理を終了");
      }

      // エラーを特定してキャッチ
      // try
      // {
      //   int[] test = { 1, 2, 3 };
      //   System.Console.WriteLine(test[4]);
      // }
      // catch (IndexOutOfRangeException e)
      // {
      //   System.Console.WriteLine(e);
      // }
      // finally
      // {
      //   System.Console.WriteLine("処理を終了");
      // }

      //ユーザ定義エラー
      // throw new ArrayError();
    }
  }
}
