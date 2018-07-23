using System;

namespace CodingBasics
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Questions");

      /*ArraysAndStrings arrays = new ArraysAndStrings();
      Console.WriteLine("Arrays");
      arrays.questionOne("");
      //arrays.questionTwo("");
      arrays.questionThree("");
      arrays.questionFour("", "");
      arrays.questionFive("");
      arrays.questionEight("", "");
      Console.WriteLine("-----------------------------------------------------------------------");
      */

      OOP oop = new OOP();
      Console.WriteLine("OOP");
      oop.questionOne();
      Console.WriteLine("-----------------------------------------------------------------------");

      Console.ReadLine();
    }
  }
}
