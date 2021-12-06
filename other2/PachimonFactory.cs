using PachittoMonster;

namespace Main
{
  class PachimonFactory
  {
    /// <summary>
    /// 指定された番号のパチモンを生成
    /// </summary>
    /// <param name="no">番号</param>
    public Pachimon create(int no)
    {
      Pachimon pachimon = null;
      if (no == 1)
      {
        pachimon = new Pekachu();
      }

      if (no == 2)
      {
        pachimon = new Husigidana();
      }

      if (no == 3)
      {
        pachimon = new Dorugame();
      }

      return pachimon;
    }
  }
}