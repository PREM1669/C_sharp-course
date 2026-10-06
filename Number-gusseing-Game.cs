class NumberGuessingGame
{
  public static void show()
  {
    // int Guess=0;
    // Random rand=new Random();
    // int randomNumber=rand.Next(1,100);

    // while (Guess!= randomNumber)
    // {
    // System.Console.WriteLine("Enter numbers between 1-100");
    // Guess=Convert.ToInt16(Console.ReadLine());

    // if(Guess < randomNumber)
    // {
    //   System.Console.WriteLine(Guess + "is to low");
    // }
    // else if (Guess > randomNumber)
    // {
    //   System.Console.WriteLine(Guess + "is to high");
    // }
    // else
    // {
    //   System.Console.WriteLine(Guess + "is the perfect guess");
    // }

    int Guess;
    bool playAgain=true;
    int min=1;
    int max=101;
    int Guesses;
    string response="";
    Random rand=new Random();
    int randomNumber=0;

    while (playAgain)
    {
       Guess=0;
       Guesses=0;
       randomNumber=rand.Next(min,max);

       while (Guess!= randomNumber)
        {
          System.Console.WriteLine("Enter numbers between"+" "+min+" " +"and"+" "+ max);
          Guess=Convert.ToInt16(Console.ReadLine());
          System.Console.WriteLine(Guess +" "+ "Guess");

          if(Guess < randomNumber)
          {
            System.Console.WriteLine(Guess +" "+ "is to low");
          }
          else if (Guess > randomNumber)
          {
            System.Console.WriteLine(Guess +" "+ "is to high");
          }
          Guesses++;
        }
        System.Console.WriteLine(randomNumber + "randomNumber");
        System.Console.WriteLine("YOU WON !");
        System.Console.WriteLine("Total guesses:" +" "+ Guesses);

        System.Console.WriteLine("Would you like to play again (Y/N):");
        response=(Console.ReadLine() ?? "").Trim().ToUpperInvariant();

        if (response=="Y")
        {
          playAgain=true;
        }
        else
        {
          playAgain=false;
        }
    }
    System.Console.WriteLine("Thanks for palying......$");
  }
}