using System;
  
class Game { 
  
    // Main Method 
    static public void Main(String[] args) 
    { 
        Console.WriteLine("Welcome to Hanabi!"); 
        HanabiGame game = new HanabiGame();
        game.SetUpGame();
        game.PlayGame();
        // Deck deck = new Deck();
        // Discard discard = new Discard();
        // Console.WriteLine(deck.IsEmpty());
        // List<Card> hand = deck.MakeHand(5);
        // for (int i = 0; i < 5; i++) {
        //     Console.WriteLine(hand[i].ToString());
        // }
        // Player player1 = new Player("Joel", hand);
        // Card removedCard = player1.RemoveCard(player1.GetCards()[0]);
        // for (int i = 0; i < 4; i++) {
        //     Console.WriteLine(player1.GetCards()[i].ToString());
        // }
        // discard.DiscardCard(removedCard);
        // Dictionary<int,int> whiteCards = discard.GetWhiteCards();
        // foreach(KeyValuePair<int, int> entry in whiteCards) {
        //     string str = entry.Key + " " + entry.Value;
        //     Console.WriteLine(str);
        // }
        // player1.AddCard(deck.DrawCard());
        // for (int i = 0; i < 5; i++) {
        //     Console.WriteLine(player1.GetCards()[i].ToString());
        // }
    } 
} 