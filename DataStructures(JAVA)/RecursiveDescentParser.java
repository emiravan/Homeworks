package hw;

public class RecursiveDescentParser {

    private String input;
    private int index;

    public RecursiveDescentParser(String input) {
        this.input = input;
        this.index = 0;
    }

    public void rdParser() {
        try {
            parseExpression();
            System.out.println("Result: " + input + " is recognized by the grammar");
        } catch (ParseException e) {
            System.out.println("Result: " + input + " is not recognized by the grammar");
        }
    }

    private void parseExpression() throws ParseException {
        parseTerm();
        while (match('+') || match('-')) {
            parseTerm();
        }
    }

    private void parseTerm() throws ParseException {
        parseFactor();
        while (match('*') || match('/')) {
            parseFactor();
        }
    }

    private void parseFactor() throws ParseException {
        if (match('(')) {
            parseExpression();
            match(')');
        } else if (isDigit()) {
            consumeNumber();
        } else if (isLetter()) {
            consumeIdentifier();
        } else {
            throw new ParseException("Unexpected token");
        }
    }

    private void consumeNumber() throws ParseException {
        while (isDigit()) {
            consume();
        }
    }

    private void consumeIdentifier() throws ParseException {
        while (isLetter()) {
            consume();
        }
    }

    private boolean match(char expected) throws ParseException {
        if (index < input.length() && input.charAt(index) == expected) {
            consume();
            return true;
        }
        return false;
    }

    private void consume() {
        index++;
    }

    private boolean isDigit() {
        return index < input.length() && Character.isDigit(input.charAt(index));
    }

    private boolean isLetter() {
        return index < input.length() && Character.isLetter(input.charAt(index));
    }

    public static void main(String[] args) {
        RecursiveDescentParser parser1 = new RecursiveDescentParser("(sum+47)/total");
        parser1.rdParser();

        RecursiveDescentParser parser2 = new RecursiveDescentParser("a*2//(b*3)+c+2d");
        parser2.rdParser();
    }
}

class ParseException extends Exception {
    public ParseException(String message) {
        super(message);
    }
}

