using PachittoMonster;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      PachimonFactory pachimonFactory = new PachimonFactory();

      Pachimon patimon1 = pachimonFactory.create(1);
      patimon1.ShowDetail();

      System.Console.WriteLine();
      System.Console.WriteLine("-------------------");
      System.Console.WriteLine();

      Pachimon patimon2 = pachimonFactory.create(2);
      patimon2.ShowDetail();

      System.Console.WriteLine();
      System.Console.WriteLine("-------------------");
      System.Console.WriteLine();

      Pachimon patimon3 = pachimonFactory.create(3);
      patimon3.ShowDetail();
    }
  }
}
