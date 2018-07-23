using System;

namespace CodingBasics
{
  class OOP
  {

    /// <summary>
    /// Design the data structures for a generic deck of cards. Explain how you would subclass it to implement particular card games.
    /// </summary>
    public void questionOne()
    {
      Deck deck = new Deck();
      var card = deck.DrawCard();
      Console.WriteLine($"{card.face} of {card.suit}");
      var card2 = deck.DrawCard();
      Console.WriteLine($"{card2.face} of {card2.suit} with a hand value of {card2.value()}");
      var card3 = deck.DrawCard();
      Console.WriteLine($"{card3.face} of {card3.suit} with a hand value of {card3.value()}");
    }

    /// <summary>
    /// Imagine you have a call center with three levels of employees: fresher, technical lead (TL), product manager (PM). 
    /// There can be multiple employees, but only one TL or PM. An incoming telephone call must be allocated to a fresher who is free. 
    /// If a fresher can’t handle the call, he or she must escalate the call to technical lead. 
    /// If the TL is not free or not able to handle it, then the call should be escalated to PM. Design the classes and data structures for this problem. 
    /// Implement a method getCallHandler().
    /// </summary>
    public void questionTwo()
    {
    }

    /// <summary>
    /// Design a musical juke box using object oriented principles.
    /// </summary>
    public void questionThree()
    {
    }

    /// <summary>
    /// Design a chess game using object oriented principles.
    /// </summary>
    public void questionFour()
    {
    }

    /// <summary>
    /// Design the data structures for an online book reader system.
    /// </summary>
    public void questionFive()
    {
    }

    /// <summary>
    /// Implement a jigsaw puzzle. Design the data structures and explain an algorithm to solve the puzzle.
    /// </summary>
    public void questionSix()
    {
    }

    /// <summary>
    /// Explain how you would design a chat server. In particular, provide details about the various backend components, classes, and methods. 
    /// What would be the hardest problems to solve?
    /// </summary>
    public void questionSeven()
    {
    }

    /// <summary>
    /// Othello is played as follows: Each Othello piece is white on one side and black on the other.
    /// When a piece is surrounded by its opponents on both the left and right sides, or both the top and bottom, it is said to be captured and its color is flipped. 
    /// On your turn, you must capture at least one of your opponent’s pieces. The game ends when either user has no more valid moves,
    /// and the win is assigned to the person with the most pieces. Implement the object oriented design for Othello.
    /// </summary>
    public void questionEight()
    {
    }

    /// <summary>
    /// Explain the data structures and algorithms that you would use to design an in-memory file system. 
    /// Illustrate with an example in code where possible.
    /// </summary>
    public void questionNine()
    {
    }

    /// <summary>
    /// Describe the data structures and algorithms that you would use to implement a garbage collector in C++.
    /// </summary>
    public void questionTen()
    {
    }
  }
}
