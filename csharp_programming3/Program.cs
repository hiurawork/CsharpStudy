using PachittoMonster;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1匹目
      Pachimon pekachu1 = new Pachimon("ぺかちゅう");
      pekachu1.ShowName("このパチモンは ");
      pekachu1.ShowSkill();

      // 2匹目
      Pachimon pekachu2 = new Pachimon("ぺかちゅう２号", "十ボルト");
      pekachu2.ShowName();
      pekachu2.ShowSkill();
    }
  }
}
