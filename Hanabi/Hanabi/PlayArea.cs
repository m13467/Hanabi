using System.Dynamic;

class PlayArea{
    private int red;
    private int blue;
    private int green;
    private int white;
    private int yellow;
    private int hints;
    private int explosions;

    public PlayArea() {
        red = 0;
        blue = 0;
        green = 0;
        white = 0;
        yellow = 0;
        hints = 8; //TODO: check the actual value
        explosions = 3; 
    }

    public bool PlayCard(Card card) {
        switch (card.GetColor()) {
            case Color.RED: 
                if (card.GetNumber() == red+1) {
                    red++;
                    return true;
                } else {
                    explosions -= 1;
                    break;
                }
            case Color.BLUE: 
                if (card.GetNumber() == blue+1) {
                    blue++;
                    return true;
                } else {
                    explosions -= 1;
                    break;
                }
            case Color.GREEN: 
                if (card.GetNumber() == green+1) {
                    green++;
                    return true;
                } else {
                    explosions -= 1;
                    break;
                }
            case Color.WHITE: 
                if (card.GetNumber() == white+1) {
                    white++;
                    return true;
                } else {
                    explosions -= 1;
                    break;
                }
            case Color.YELLOW: 
                if (card.GetNumber() == yellow+1) {
                    yellow++;
                    return true;
                } else {
                    explosions -= 1;
                    break;
                }
        }
        return false;
    }

    public int Score() {
        return red + blue + green + white + yellow;
    }

    public void IncreaseHints() {
        hints++;
    }

    public void UseHint() {
        hints--;
    }

    public string ToString() {
        string str = "Current stacks: R-" + red + " B-" + blue + " G-" + green + " W-"+ white + " Y-" + yellow;
        str += "\nHints: " + hints + " \nNumber left til explosion: " + explosions;
        return str;
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

    public bool CheckExplosionState() {
        if (explosions <= 0 ) {
            return true;
        } 
        return false;
    }

    public int GetHints() {
        return hints;
    }
}