using System;

namespace PachittoMonster
{
  /// <summary>
  /// パチモンクラス
  /// </summary>
  abstract class Pachimon : IPachimon
  {
    //パチモンの基本の名前
    protected string baseName = "none";

    //技名
    protected string skill = "いたいあたり";

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public Pachimon(string baseName, string skill)
    {
      this.baseName = baseName;
      this.skill = skill;
    }

    /// <summary>
    /// 名前を表示
    /// </summary>
    public void ShowBaseName()
    {
      System.Console.WriteLine(this.baseName);
    }

    /// <summary>
    /// 技を表示
    /// </summary>
    public void ShowSkill()
    {
      System.Console.WriteLine(this.skill);
    }

    /// <summary>
    /// 名前を表示
    /// </summary>
    abstract public void ShowName();

    /// <summary>
    /// 詳細を表示
    /// </summary>
    abstract public void ShowDetail();
  }
}
