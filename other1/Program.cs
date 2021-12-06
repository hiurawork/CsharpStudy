namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      Common common = new Common();

      string result = common.ReadLine();
      common.WriteLine(result);

      Reader reader = new Reader();
      Writer writer = new Writer();

      string result2 = reader.ReadLine();
      writer.WriteLine(result2);
    }
  }
}
