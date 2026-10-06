using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Myapp
{
  class App
  {
    static void Main(string[] args)
    {

      // string name = "Prem";
      // int age = 18;
      // age*=2;
      // double height = 5.9;
      // bool isStudent = true;
      // int x; 
      // x=0612;
      // int y =1003;
      // Console.WriteLine(x);
      // Console.WriteLine(y) ;

      // Console.WriteLine($"Name: {name}");
      // Console.WriteLine($"Age: {age}");
      // Console.WriteLine($"Height: {height}");
      // Console.WriteLine($"Student status confirmed: {isStudent}");
      // Console.Beep();
      // int b=Convert.ToInt32(height);
      // Console.WriteLine(b);
  
      // Console.WriteLine("what is your name? ");
      // string name=Console.ReadLine();

      // Console.WriteLine("what is your age ? ");
      // int age=Convert.ToInt32(Console.ReadLine()); 

      // Console.WriteLine($"Hello {name}");
      // Console.WriteLine($"Your age {age} years old");
      // Console.WriteLine(age);

    //   double x=64;

    //  double y=Math.Pow(x,4);
    //  double a=Math.Sqrt(x);
    //  Console.WriteLine(a);

    // Random rand= new Random();

    // int num=rand.Next(1,10);
    // Console.WriteLine(num);

    // string name="Prem swaroop";

    // string fullname=name.Replace("S","Mr.");
    // string username=name.Insert(0,"@");
    // string firstName=name.Substring(0,4);
    // string lastName=name.Substring(4,8);
    // Console.WriteLine(lastName);

    // Console.WriteLine("Enter your rollno:");
    // string rollno=Console.ReadLine();

    //   if (rollno=="23671A12B4")
    //   {
    //     System.Console.WriteLine("Your the student of IT branch");
    //   }
    //   else if (rollno=="23171651A23")
    //   {
    //     System.Console.WriteLine("Your are not from IT branch");
    //   }
    //   else
    //   {
    //     System.Console.WriteLine("please enter the correct foramt of rollno");
    //   }

    // Console.WriteLine("what day is today:");
    // string day=Console.ReadLine();

    //   switch (day)
    //   {
    //     case "Monday":
    //       System.Console.WriteLine("It's monday");
    //       break;

    //       case "Tuesday":
    //       System.Console.WriteLine("It's Tuesday");
    //       break;

    //       case "Wednesday":
    //       System.Console.WriteLine("It's Wednesday");
    //       break;

    //       case "Thursday":
    //       System.Console.WriteLine("It's Thursday");
    //       break;

    //       case "Firday":
    //       System.Console.WriteLine("It's Firday");
    //       break;

    //       case "saturday":
    //       System.Console.WriteLine("It's saturday");
    //       break;

    //       case "sunday":
    //       System.Console.WriteLine("It's sunday");
    //       break;

    //     default: 
    //       System.Console.WriteLine(day + "is not a day "); 
    //       break;
      // }

      // while loop

    //  int i=1;
    //   while (i < 11)
    //   {
    //     System.Console.WriteLine($"count:{i}");
    //     i++;
    //   }
      // int n = 1, sum = 0;
      // while (n <= 100)
      // {
      //     sum +=n;
      //     n++;
      // }
      // Console.WriteLine(sum); // 5050

    int number=98765,digits=0;
      while (number > 0)
      {
        number/=10;
        digits++;
      }
      System.Console.WriteLine(digits);

    // do/while loop

      //   int i=1;
      // do
      // {
      //   System.Console.WriteLine(i);
      //   i++;
      // }
      // while (i < 11);

   }
 }
}