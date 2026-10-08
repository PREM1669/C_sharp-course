using System.Runtime.CompilerServices;

class RockScissors
{
 public static void show()
  {
    string player;
    string computer;
    string answer;
    bool playAgain=true;
    Random rand=new Random();

    while (playAgain)
    {
      player="";
      computer="";
      answer="";
      while(player!="ROCK" && player!="PAPER" && player!="SCISSORS")
      {
        System.Console.Write("Enter ROCK,PAPER or SCISSORS:"); 
        player=Console.ReadLine() ?? "";
        player=player.ToUpper();

        switch(rand.Next(1,4)){
           
           case 1:
             computer ="ROCK";
             break;
           case 2:
             computer ="PAPER";
             break;
           case 3:
             computer ="SCISSORS";
             break;       
        }
        System.Console.WriteLine("player :" +player);
        System.Console.WriteLine("Computer : "+ computer);

        switch (player)
        {
          case "ROCK":
          if(computer== "ROCK")
            {
              System.Console.WriteLine("It's s Draw");
            }
            else if (computer == "PAPER")
            {
              System.Console.WriteLine("You losee");
            }
            else
            {
              System.Console.WriteLine("You WON");
            }
          break;


          case "PAPER":
          if(computer== "ROCK")
            {
              System.Console.WriteLine("You WON");
            }
            else if (computer == "PAPER")
            {
              System.Console.WriteLine("It's s Draw");
            }
            else
            {
              System.Console.WriteLine("You loose");
            }
          break;


          case "SCISSORS":
            if(computer== "ROCK")
            {
              System.Console.WriteLine("You losee");
            }
            else if (computer == "PAPER")
            {
              System.Console.WriteLine("You WON");
            }
            else
            {
              System.Console.WriteLine("It's a draw");
            }
          break;
        }
      }
        System.Console.WriteLine("Would you like to play again (Y/N):");
        answer=Console.ReadLine() ?? "";
        answer=answer.ToUpper();

        if (answer=="Y")
        {
          playAgain=true;
        }
        else
        {
          playAgain=false;
        }

    }
  System.Console.WriteLine("Thanks for playing....");
    
  }
}