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

    public void GiveHintNumber(int num) {
        for (int i = 0; i < hand.Count; i++) {
            if (hand[i].GetNumber() == num) {
                hand[i].SetKnowNumber(true);
            }
        }
    }

    public void GiveHintColor(Color color) {
        for (int i = 0; i < hand.Count; i++) {
            if (hand[i].GetColor() == color) {
                hand[i].SetKnowColor(true);
            }
        }
    }

    public string PrintHand() {
        string str = "";
        for (int i = 0; i < this.hand.Count; i++) {
            str += this.hand[i].ToString() + "    ";
        }
        return str;
    }

    public string PrintPlayerHand() {
        string str = "";
        for (int i = 0; i < this.hand.Count; i++) {
            string card = "";
            if (this.hand[i].IsKnowNumber()) {
                card += this.hand[i].GetNumber() + " ";
            }
            if (this.hand[i].IsKnowColor()) {
                card += this.hand[i].GetColor() + " ";
            }
            if (card == "") {
                card = "?";
            }
            str += card + " ";
        }
        return str;
    }

    public string GetName() {
        return this.name;
    }

    public List<Card> GetCards() {
        return this.hand;
    }
}