using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890";
      string specialChars = "?!@#$%^&*()";

      Console.WriteLine("Enter a password: ");
      string input = Console.ReadLine();
      int score = 0;
      if (input.Length >= minLength){
        score++;
      }

      if (Tools.Contains(input, uppercase)){
        score++;
      }

      if (Tools.Contains(input, lowercase)){
        score++;
      }

      if (Tools.Contains(input, digits)){
        score++;
      }

      if (Tools.Contains(input, specialChars)){
        score++;
      }

      if (input == "password"){
        score = 0;
      }

      
      Console.WriteLine(score);

      switch(score){

        case 1:
        Console.WriteLine("Weak");
        break;

        case 2:
        Console.WriteLine("Medium");
        break;

        case 3:
        Console.WriteLine("Strong");
        break;

        case 4:
        Console.WriteLine("Extremely strong!");
        break;

        case 5:
        Console.WriteLine("Extremely strong again!");
        break;

        default:
        Console.WriteLine("No standards met");
        break;
      }
    }
  }
}