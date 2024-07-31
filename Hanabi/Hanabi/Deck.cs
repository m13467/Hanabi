using System.Collections;
class Deck {
    private Stack<Card> deck;

    public Deck() {
        this.deck = new Stack<Card>();
        // Randomized version
        // List<Card> tempDeck = new List<Card>();
        // for (int i = 0; i < 3; i++) {
        //     tempDeck.Add(new Card(Color.RED, 1));
        //     tempDeck.Add(new Card(Color.GREEN, 1));
        //     tempDeck.Add(new Card(Color.BLUE, 1));
        //     tempDeck.Add(new Card(Color.YELLOW, 1));
        //     tempDeck.Add(new Card(Color.WHITE, 1));
        // }
        // for (int i = 0; i < 2; i++) {
        //     tempDeck.Add(new Card(Color.RED, 2));
        //     tempDeck.Add(new Card(Color.GREEN, 2));
        //     tempDeck.Add(new Card(Color.BLUE, 2));
        //     tempDeck.Add(new Card(Color.YELLOW, 2));
        //     tempDeck.Add(new Card(Color.WHITE, 2));
        // }
        // for (int i = 0; i < 2; i++) {
        //     tempDeck.Add(new Card(Color.RED, 3));
        //     tempDeck.Add(new Card(Color.GREEN, 3));
        //     tempDeck.Add(new Card(Color.BLUE, 3));
        //     tempDeck.Add(new Card(Color.YELLOW, 3));
        //     tempDeck.Add(new Card(Color.WHITE, 3));
        // }
        // for (int i = 0; i < 2; i++) {
        //     tempDeck.Add(new Card(Color.RED, 4));
        //     tempDeck.Add(new Card(Color.GREEN, 4));
        //     tempDeck.Add(new Card(Color.BLUE, 4));
        //     tempDeck.Add(new Card(Color.YELLOW, 4));
        //     tempDeck.Add(new Card(Color.WHITE, 4));
        // }
        // tempDeck.Add(new Card(Color.RED, 5));
        // tempDeck.Add(new Card(Color.GREEN, 5));
        // tempDeck.Add(new Card(Color.BLUE, 5));
        // tempDeck.Add(new Card(Color.YELLOW, 5));
        // tempDeck.Add(new Card(Color.WHITE, 5));
        // var rand = new Random();
        // for (int i = 0; i < 30; i++) {
        //     int firstIndex = rand.Next(50);
        //     int secondIndex = rand.Next(50);
        //     Card tempCard = tempDeck[firstIndex];
        //     tempDeck[firstIndex] = tempDeck[secondIndex];
        //     tempDeck[secondIndex] = tempCard;
        // }
        // for (int i = 0; i < 50; i++) {
        //     deck.Push(tempDeck[i]);
        // }

        // Non-randomized version for testing
        for (int i = 0; i < 3; i++) {
            this.deck.Push(new Card(Color.RED, 1));
            this.deck.Push(new Card(Color.GREEN, 1));
            this.deck.Push(new Card(Color.BLUE, 1));
            this.deck.Push(new Card(Color.YELLOW, 1));
            this.deck.Push(new Card(Color.WHITE, 1));
        }
        for (int i = 0; i < 2; i++) {
            this.deck.Push(new Card(Color.RED, 2));
            this.deck.Push(new Card(Color.GREEN, 2));
            this.deck.Push(new Card(Color.BLUE, 2));
            this.deck.Push(new Card(Color.YELLOW, 2));
            this.deck.Push(new Card(Color.WHITE, 2));
        }
        for (int i = 0; i < 2; i++) {
            this.deck.Push(new Card(Color.RED, 3));
            this.deck.Push(new Card(Color.GREEN, 3));
            this.deck.Push(new Card(Color.BLUE, 3));
            this.deck.Push(new Card(Color.YELLOW, 3));
            this.deck.Push(new Card(Color.WHITE, 3));
        }
        for (int i = 0; i < 2; i++) {
            this.deck.Push(new Card(Color.RED, 4));
            this.deck.Push(new Card(Color.GREEN, 4));
            this.deck.Push(new Card(Color.BLUE, 4));
            this.deck.Push(new Card(Color.YELLOW, 4));
            this.deck.Push(new Card(Color.WHITE, 4));
        }
        this.deck.Push(new Card(Color.RED, 5));
        this.deck.Push(new Card(Color.GREEN, 5));
        this.deck.Push(new Card(Color.BLUE, 5));
        this.deck.Push(new Card(Color.YELLOW, 5));
        this.deck.Push(new Card(Color.WHITE, 5));
    }

    public List<Card> MakeHand(int handSize) {
        List<Card> hand = new List<Card>();
        for (int i = 0; i < handSize; i++) {
            hand.Add(this.deck.Pop());
        }
        return hand;
    }

    public Card DrawCard() {
        return this.deck.Pop();
    }

    public bool IsEmpty() {
        return this.deck.Count == 0;
    }
}