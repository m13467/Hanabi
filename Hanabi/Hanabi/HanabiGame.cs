using System.Linq.Expressions;

class HanabiGame{
    private List<Player> players;
    private PlayArea playArea;
    private Discard discard;
    private Deck deck;
    private int numOfPlayers;

    public HanabiGame() {
        playArea = new PlayArea();
        discard = new Discard();
        deck = new Deck();
        players = new List<Player>();
    }

    public bool SetUpGame() {
        Console.WriteLine("How many players are there?");
        string temp = Console.ReadLine();
        if (temp == null) {
            Console.WriteLine("Error");
            return false;
        } else {
            numOfPlayers = Int32.Parse(temp);
        }


        int handSize = 0;
        if (numOfPlayers <= 3) {
            handSize = 5;
        } else {
            handSize = 4;
        }
        for (int i = 0; i < numOfPlayers; i++) {
            Console.WriteLine("What is the name of player" + (i+1) + "?");
            string name = Console.ReadLine();
            if (name == null) {
                Console.WriteLine("Error");
                name = "Player" + (i+1);
                return false;
            }
            List<Card> hand = deck.MakeHand(handSize);
            this.players.Add(new Player(name, hand));
        }
        return true;
    }

    public int PlayGame() {
        int countDownAfterDeckRunsOut = 0; 
        while (countDownAfterDeckRunsOut < numOfPlayers) {
            for (int i = 0; i < numOfPlayers; i++) {
                bool tryAgain = true;
                while (tryAgain) {
                    Console.WriteLine(players[i].GetName() + "\'s turn. Enter \"go\" to start your turn.");
                    // TODO: have the user press something to confirm they are ready to start their turn.
                    string startKey = Console.ReadLine();
                    if (startKey == "go" || startKey == "Go" || startKey == "GO") {
                        printInfoForTurn(players[i]);
                        Player activePlayer = players[i];
                        bool wrongInput = true;
                        while (wrongInput) {
                            Console.WriteLine("\nWould you like to give a hint (H), play a card(P), or discard a card(D)?");
                            string action = Console.ReadLine();
                            if (action == "h" || action == "H") {
                                if (playArea.GetHints() == 0 ) {
                                    Console.WriteLine("There is not enough hints for you to give a hint.");
                                    continue;
                                }
                                bool personSelected = false;
                                string input = "";
                                Player hintPlayer = null; 
                                while (!personSelected) {
                                    Console.Write("Who do you want to give a hint to? (");
                                    string str = "";
                                    for (int j = 0; j < numOfPlayers; j++) {
                                        if (players[j].GetName() != activePlayer.GetName()) {
                                            str += players[j].GetName() + ", ";
                                        } 
                                    }
                                    Console.Write(str + ")\n");
                                    input = Console.ReadLine();
                                    if (input == activePlayer.GetName()) {
                                        continue;
                                    }
                                    for (int j = 0; j < numOfPlayers; j++) {
                                        if (players[j].GetName() == input) {
                                            hintPlayer = players[j];
                                        } 
                                    }
                                    if (hintPlayer == null) {
                                        Console.WriteLine("Error finding player");
                                        continue;
                                    } else {
                                        personSelected = true;
                                    }
                                }
                                bool loopFinished = false;
                                while (!loopFinished) {
                                    Console.WriteLine("Would you like to tell them the number (n) or color (c)?");
                                    input = Console.ReadLine();
                                    if (input == "n" || input == "N") {
                                        Console.WriteLine("Which number would you like to point out to them?");
                                        input = Console.ReadLine();
                                        if (input != null) {
                                            int number = Int32.Parse(input);
                                            if (number > 5 || number < 1) {
                                                Console.WriteLine("invalid number");
                                                continue;
                                            }
                                            hintPlayer.GiveHintNumber(number);
                                            loopFinished = true;
                                        } else {
                                            Console.WriteLine("invalid number");
                                        }
                                    } else if (input == "c" || input == "C") {
                                        Console.WriteLine("Which color would you like to point out to them?");
                                        input = Console.ReadLine();
                                        if (input != null) {
                                            switch (input.ToLower()) {
                                                case "red":
                                                    hintPlayer.GiveHintColor(Color.RED);
                                                    break;
                                                case "blue":
                                                    hintPlayer.GiveHintColor(Color.BLUE);
                                                    break;
                                                case "green":
                                                    hintPlayer.GiveHintColor(Color.GREEN);
                                                    break;
                                                case "white":
                                                    hintPlayer.GiveHintColor(Color.WHITE);
                                                    break;
                                                case "yellow":
                                                    hintPlayer.GiveHintColor(Color.YELLOW);
                                                    break;
                                                default: 
                                                    Console.WriteLine("Invalid color");
                                                    continue;
                                            }
                                            loopFinished = true;
                                        } else {
                                            Console.WriteLine("invalid color");
                                        }
                                    }
                                }
                                wrongInput = false;
                                playArea.UseHint();
                            } else if (action == "p" || action == "P") {
                                //TODO: Have UI so you can select a card
                                bool loopFinished = false;
                                while (!loopFinished) {
                                    Console.WriteLine("What card would you like to play? (1, 2, 3, 4, or 5)");
                                    string card = Console.ReadLine();
                                    int cardNum = 0;
                                    if (card == null) {
                                        Console.WriteLine("Error couldn't play");
                                    } else {
                                        cardNum = Int32.Parse(card);
                                    }
                                    if (cardNum > activePlayer.GetCards().Count || cardNum <= 0) {
                                        Console.WriteLine("Error card not available");
                                    } else {
                                        Card playedCard = activePlayer.GetCards()[cardNum-1];
                                        bool success = playArea.PlayCard(playedCard);
                                        if (!success) {
                                            Console.WriteLine("You played an incorrect card.");
                                            if (playArea.CheckExplosionState()) {
                                                Console.WriteLine("You have exploded.");
                                                countDownAfterDeckRunsOut = 10;
                                                break;
                                            }
                                        }
                                        activePlayer.RemoveCard(playedCard);
                                        Card newCard = deck.DrawCard();
                                        activePlayer.AddCard(newCard);
                                        loopFinished = true;
                                    }
                                }
                                wrongInput = false;
                            } else if (action == "d" || action == "D") {
                                //TODO: Have UI so they can select the card 
                                bool loopFinished = false;
                                while(!loopFinished) {
                                    Console.WriteLine("What card do you want to discard? (1, 2, 3, 4, or 5)");
                                    string card = Console.ReadLine();
                                    int cardNum = 0;
                                    if (card == null) {
                                        Console.WriteLine("Error couldn't discard");
                                    } else {
                                        cardNum = Int32.Parse(card);
                                    }
                                    if (cardNum > activePlayer.GetCards().Count || cardNum <= 0) {
                                        Console.WriteLine("Error card not available");
                                    } else {
                                        Card discardedCard = activePlayer.GetCards()[cardNum-1];
                                        discard.DiscardCard(discardedCard);
                                        activePlayer.RemoveCard(discardedCard);
                                        Card newCard = deck.DrawCard();
                                        activePlayer.AddCard(newCard);
                                        loopFinished = true;
                                    }
                                }
                                wrongInput = false;
                            }
                        }
                        tryAgain = false;
                    }
                }
            }
        }
        return playArea.Score();
    }

    private void printInfoForTurn(Player activePlayer) {
        // R = Red, B = Blue, G = Green, Y = Yellow, W = White, C = knows color, N = knows number
        // print each players hand
        Console.WriteLine("\n\n\n\nCurrent game stats. (N: number known, C: color known, R: red, B: blue, Y: yellow, W: white, G: green)");
        string str = "";
        for (int i = 0; i < numOfPlayers; i++) {
            if (players[i].GetName() != activePlayer.GetName()) {
                str += players[i].GetName() + "'s hand: " + players[i].PrintHand() + "\n";
            } else {
                str += "Your hand: " + activePlayer.PrintPlayerHand() + "\n";
            }
        }
        Console.WriteLine(str);
        // print discard
        Console.WriteLine("Discard pile:\n" + discard.ToString());
        // print playarea
        Console.WriteLine(playArea.ToString());
    }
}