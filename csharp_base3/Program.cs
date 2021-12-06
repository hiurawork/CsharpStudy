namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      int result = addition1(1, 2);

      System.Console.Out.WriteLine(result);

      addition2(1, 2);


      addition3();
    }

    private static int addition1(int a, int b)
    {
      int result = a + b;

      return result;
    }

    private static void addition2(int a, int b)
    {
      int result = a + b;

      System.Console.Out.WriteLine(result);
    }

    private static void addition3()
    {
      int result = 1 + 2;

      System.Console.Out.WriteLine(result);
    }
  }
}
