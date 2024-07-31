class Player {
    private string name;
    private List<Card> hand;

    public Player(string name, List<Card> hand) {
        this.name = name;
        this.hand = hand;
    }

    public Card RemoveCard(Card card) {
        this.hand.Remove(card);
        return card;
    }

    public void AddCard(Card card) {
        this.hand.Add(card);
    }

    public string GetName() {
        return this.name;
    }

    public List<Card> GetCards() {
        return this.hand;
    }
}