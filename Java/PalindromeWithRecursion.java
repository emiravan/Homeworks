
public class main {

	public static void main(String[] args) {
        System.out.println(isPalindrome("level"));              
        System.out.println(isPalindrome("Madam Im Adam"));      
        System.out.println(isPalindrome("No lemon, no melon"));  
    }
	
	public static boolean isPalindrome(String str) {

        if (str.length() <= 1) {
            return true;
        } else {

            if (str.charAt(0) == str.charAt(str.length() - 1)) {
                return isPalindrome(str.substring(1, str.length() - 1));
            } else {
                return false;
            }
        }

}
