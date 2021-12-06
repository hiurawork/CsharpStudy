namespace Main
{
  /// <summary>
  /// パチモンクラス
  /// </summary>
  class Pachimon
  {
    //パチモンの名前
    private string name = "名無し";

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="name">名前を指定</param>
    public Pachimon(string name)
    {
      this.name = name;
    }

    /// <summary>
    /// 名前を表示
    /// </summary>
    public void ShowName()
    {
      System.Console.WriteLine(this.name);
    }
  }
}
