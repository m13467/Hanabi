enum Color {
    RED,
    GREEN,
    BLUE,
    YELLOW,
    WHITE
}

class Card {
    private Color color;
    private int number;
    private bool knowColor;
    private bool knowNumber;

    public Card(Color color, int number) {
        this.color = color;
        this.number = number;
        this.knowColor = false;
        this.knowNumber = false;
    }

    public void SetKnowColor(bool knowColor) {
        this.knowColor = knowColor;
    }

    public void SetKnowNumber(bool knowNumber) {
        this.knowNumber = knowNumber;
    }

    public Color GetColor() {
        return this.color;
    }

    public int GetNumber() {
        return this.number;
    }

    public bool IsKnowColor() {
        return this.knowColor;
    }

    public bool IsKnowNumber() {
        return this.knowNumber;
    }

    new public string ToString() {
        String str = this.number.ToString();
        switch (this.color) {
            case Color.RED:
                str += " red";
                break;
            case Color.BLUE:
                str += " blue";
                break;
            case Color.WHITE:
                str += " white";
                break;
            case Color.YELLOW:
                str += " yellow";
                break;
            case Color.GREEN:
                str += " green";
                break;
        }
        return str;
    }
}