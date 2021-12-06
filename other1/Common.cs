namespace Main
{
  class Common
  {
    /// <summary>
    /// 指定されたメッセージを表示
    /// </summary>
    /// <param name="message">メッセージ</param>
    public void WriteLine(string message)
    {
      System.Console.WriteLine(message);
    }

    /// <summary>
    /// 読み込みを行う
    /// </summary>
    /// <returns>読み込まれた値を返す</returns>
    public string ReadLine()
    {
      string result = System.Console.ReadLine();

      return result;
    }
  }
}