using PachittoMonster;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1匹目
      Pachimon pekachu1 = new Pachimon("ぺかちゅう");
      pekachu1.ShowName();
      pekachu1.ShowSkill();

      // 2匹目
      Pachimon pekachu2 = new PachittoMonster.Pachimon("ぺかちゅう２号");
      pekachu2.ShowName();
      pekachu2.Skill = "十ボルト";
      pekachu2.ShowSkill();
    }
  }
}
