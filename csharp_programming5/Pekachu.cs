using System;

namespace PachittoMonster
{
  /// <summary>
  /// ペカチュウクラス
  /// </summary>
  class Pekachu : Pachimon
  {
    // ペカチュウの名前
    private string name;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public Pekachu(string name) : base("ペカチュウ", "十ボルト")
    {
      this.name = name;
    }

    /// <summary>
    /// 名前を表示
    /// </summary>
    public override void ShowName()
    {
      System.Console.WriteLine(this.name);
    }

    /// <summary>
    /// 詳細を表示
    /// </summary>
    public override void ShowDetail()
    {
      string baseName = "このパチモンの固有名は" + base.baseName + "です。";
      string name = "このパチモンは" + this.name + "という名前です。";
      string skill = "このパチモンは" + base.skill + "という技を覚えています。";

      System.Console.WriteLine(baseName);
      System.Console.WriteLine(name);
      System.Console.WriteLine(skill);
    }
  }
}
