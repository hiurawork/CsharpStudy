using System;

namespace PachittoMonster
{
  /// <summary>
  /// パチモンクラス
  /// </summary>
  abstract class Pachimon
  {
    //パチモンの基本の名前
    private string baseName = "none";

    // パチモンの技名
    private string skill;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public Pachimon(string baseName, string skill)
    {
      this.baseName = baseName;
      this.skill = skill;
    }

    /// <summary>
    /// 詳細を表示
    /// </summary>
    public void ShowDetail()
    {
      string baseName = "このパチモンの固有名は" + this.baseName + "です。";
      string skill = "このパチモンは" + this.skill + "という技を覚えています。";

      System.Console.WriteLine(baseName);
      System.Console.WriteLine(skill);
    }
  }
}
