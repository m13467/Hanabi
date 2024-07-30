using System;
  
class Game { 
  
    // Main Method 
    static public void Main(String[] args) 
    { 
        Console.WriteLine("Welcome to Hanabi!"); 
        Card card = new Card(Color.RED, 1);
        Deck deck = new Deck();
        Console.WriteLine(deck.IsEmpty());
        List<Card> hand = deck.MakeHand(5);
        for (int i = 0; i < 5; i++) {
            hand[i].ToString();
        } 
        deck.DrawCard().ToString();
    } 
} 