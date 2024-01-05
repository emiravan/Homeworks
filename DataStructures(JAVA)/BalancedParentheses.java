import java.util.Stack;

public class BalancedParentheses {

    public static boolean checkIfBalanced(String expression) {
        Stack stack = new Stack();

        for (int i = 0; i < expression.length(); i++) {
            char currentChar = expression.charAt(i);

            if (currentChar == '(' || currentChar == '{' || currentChar == '[') {
                stack.push(currentChar);
            } else if (currentChar == ')' || currentChar == '}' || currentChar == ']') {
                if (stack.isEmpty()) {
                    return false; 
                } else {
                    char top = (char) stack.pop();
                    if ((currentChar == ')' && top != '(') ||
                        (currentChar == '}' && top != '{') ||
                        (currentChar == ']' && top != '[')) {
                        return false;
                    }
                }
            }
        }
        return stack.isEmpty();
    }
    public static void main(String[] args) {        
        System.out.println(checkIfBalanced("(A+B)+(C-D)")); 
        System.out.println(checkIfBalanced("((A+B)+(C-D)")); 
        System.out.println(checkIfBalanced("((A+B)+[C-D])")); 
        System.out.println(checkIfBalanced("((A+B)-[C-D]}"));
    }
}
