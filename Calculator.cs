class Calculator
{
  public static void show()
  {

    do
    {
      double num1=0;
      double num2=0;
      double result=0;

    System.Console.WriteLine(".....................");
    System.Console.WriteLine("Calculator program..");
    System.Console.WriteLine(".....................");

    System.Console.Write("Enter num 1:");
    num1=Convert.ToDouble(Console.ReadLine());

    System.Console.Write("Enter num 2:");
    num2=Convert.ToDouble(Console.ReadLine());

    System.Console.WriteLine("Enter the option:");
    System.Console.WriteLine("+");
    System.Console.WriteLine("-");
    System.Console.WriteLine("*");
    System.Console.WriteLine("/");

      switch (Console.ReadLine())
      {
        case "+":
        result=num1 + num2;
        System.Console.WriteLine($"Your result: {num1} + {num2}= " +result);
        break;

        case "-":
        result=num1 - num2;
        System.Console.WriteLine($"Your result: {num1} - {num2}= " +result);
        break;

        case "*":
        result=num1 * num2;
        System.Console.WriteLine($"Your result: {num1} * {num2}= " +result);
        break;

        case "/":
        result=num1 / num2;
        System.Console.WriteLine($"Your result: {num1} / {num2}= " +result);
        break;

        default:
        System.Console.WriteLine("That's was not a vaild option");
        break;
      }
      System.Console.WriteLine("Would you like to continue  ?(Y=yes,N=no): ");
   }while(Console.ReadLine().ToUpper()=="Y");
   
  System.Console.WriteLine("Bye");
  }
}