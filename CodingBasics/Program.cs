using System;

namespace CodingBasics
{
  class Program
  {
    static void Main(string[] args)
    {
      var question = "";
      Console.WriteLine("Arrays");

      Arrays arrays = new Arrays();

      arrays.questionOne("");
      arrays.questionThree("");
      arrays.questionFour("", "");

      question = Console.ReadLine();
      switch (question)
      {
        case "1":
          arrays.questionOne("");
          break;
        case "3":
          arrays.questionThree("");
          break;
        case "4":
          arrays.questionFour("", "");
          break;
        default:
          question = Console.ReadLine();
          break;
      }

      Console.ReadLine();
    }
  }
}
