class Arrays
{
  public static void show()
  {
    System.Console.Write("How many rows: ");
    int rows=Convert.ToInt16(Console.ReadLine());

     System.Console.Write("How many rows: ");
    int coloumns=Convert.ToInt16(Console.ReadLine());

     System.Console.Write("what is symbol you need : ");
    string symbol=Console.ReadLine() ?? "";

    for(int i = 0; i < rows; i++)
    {
      for(int j = 0;j < coloumns;j++)
      {
        System.Console.Write(symbol);
      }
      System.Console.WriteLine();
    }
  }
}