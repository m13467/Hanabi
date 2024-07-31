using System.Dynamic;

class PlayArea{
    private int red;
    private int blue;
    private int green;
    private int white;
    private int yellow;

    public PlayArea() {
        red = 0;
        blue = 0;
        green = 0;
        white = 0;
        yellow = 0;
    }

    public bool PlayCard(Card card) {
        switch (card.GetColor()) {
            case Color.RED: 
                if (card.GetNumber() == red+1) {
                    red++;
                    return true;
                } else {
                    return false;
                }
            case Color.BLUE: 
                if (card.GetNumber() == blue+1) {
                    blue++;
                    return true;
                } else {
                    return false;
                }
            case Color.GREEN: 
                if (card.GetNumber() == green+1) {
                    green++;
                    return true;
                } else {
                    return false;
                }
            case Color.WHITE: 
                if (card.GetNumber() == white+1) {
                    white++;
                    return true;
                } else {
                    return false;
                }
            case Color.YELLOW: 
                if (card.GetNumber() == yellow+1) {
                    yellow++;
                    return true;
                } else {
                    return false;
                }
        }
        return false;
    }

    public int Score() {
        return red + blue + green + white + yellow;
    }

    // This function returns the stack values in a list. The order will always be red, blue, green, white, yellow
    public List<int> GetStackValues() {
        List<int> stacks = new List<int>();
        stacks.Add(red);
        stacks.Add(blue);
        stacks.Add(green);
        stacks.Add(white);
        stacks.Add(yellow);
        return stacks;
    }
}