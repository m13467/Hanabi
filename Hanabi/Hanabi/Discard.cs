class Discard{
    private Dictionary<int,int> redCards;
    private Dictionary<int,int> blueCards;
    private Dictionary<int,int> whiteCards;
    private Dictionary<int,int> yellowCards;
    private Dictionary<int,int> greenCards;

    public Discard() {
        redCards = new Dictionary<int, int>();
        blueCards = new Dictionary<int, int>();
        yellowCards = new Dictionary<int, int>();
        whiteCards = new Dictionary<int, int>();
        greenCards = new Dictionary<int, int>();

        // for (int i = 0; i < 5; i++) {
        //     redCards.Add(i+1,0);
        //     blueCards.Add(i+1,0);
        //     whiteCards.Add(i+1,0);
        //     yellowCards.Add(i+1,0);
        //     greenCards.Add(i+1,0);
        // }
    }

    public void DiscardCard(Card card) {
        int num = card.GetNumber();
        switch (card.GetColor()) {
            case Color.RED:
                if (!redCards.ContainsKey(num)) {
                    redCards[num] = 1;
                } else {
                    redCards[num] = redCards[num] + 1;
                }
                break;
            case Color.BLUE:
                if (!blueCards.ContainsKey(num)) {
                    blueCards[num] = 1;
                } else {
                    blueCards[num] = blueCards[num] + 1;
                }
                break;
            case Color.WHITE:
                if (!whiteCards.ContainsKey(num)) {
                    whiteCards[num] = 1;
                } else {
                    whiteCards[num] = whiteCards[num] + 1;
                }
                break;
            case Color.YELLOW:
                if (!yellowCards.ContainsKey(num)) {
                    yellowCards[num] = 1;
                } else {
                    yellowCards[num] = yellowCards[num] + 1;
                }
                break;
            case Color.GREEN:
                if (!greenCards.ContainsKey(num)) {
                    greenCards[num] = 1;
                } else {
                    greenCards[num] = greenCards[num] + 1;
                }
                break;
        }
    }

    public Dictionary<int,int> GetRedCards() {
        return redCards;
    }

    public Dictionary<int,int> GetBlueCards() {
        return blueCards;
    }

    public Dictionary<int,int> GetWhiteCards() {
        return whiteCards;
    }

    public Dictionary<int,int> GetYellowCards() {
        return yellowCards;
    }

    public Dictionary<int,int> GetGreenCards() {
        return greenCards;
    }
}