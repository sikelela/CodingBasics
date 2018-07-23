using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Design the data structures for a generic deck of cards. Explain how you would subclass it to implement particular card games.
/// </summary>
namespace CodingBasics
{

  enum Suit
  {
    Heart = 1,
    Diamond = 2,
    Club = 3,
    Spade = 4
  }

  enum Face
  {
    Ace = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13,
  }

  class Card
  {
    public Suit suit { get; set; }
    public Face face { get; set; }
    public bool? isPlayed { get; set; }

    public Card()
    {
    }

    public Card(Suit Suit, Face Face)
    {
      suit = Suit;
      face = Face;
      isPlayed = false;
    }

    public virtual int value()
    {
      return (int)face;
    }
  }


  class Deck
  {
    public List<Card> Cards { get; set; }

    public Deck()
    {
      Cards = new List<Card>();
      int? suit = null;
      for (int i = 1; i < 5; i++)
      {
        for (int j = 1; j < 14; j++)
        {
          Cards.Add(new Card((Suit)i, (Face)j));
        }
      }
    }

    public Card DrawCard()
    {
      var Card = Cards.Where(c => c.isPlayed == false).FirstOrDefault();
      Card.isPlayed = true;
      return Card;
    }
  }

  class BlackJackCard : Card
  {
    public override int value()
    {
      return face == Face.Ace ? 11 : (int)face < 10 ? (int)face : 10;
    }

    public bool isAce()
    {
      return face == Face.Ace;
    }
  }

}
