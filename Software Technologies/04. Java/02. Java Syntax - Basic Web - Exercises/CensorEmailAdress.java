import java.util.Scanner;

public class CensorEmailAdress {
    public static void main(String[]args){
        Scanner scanner = new Scanner(System.in);

        String email = scanner.nextLine();
        String text = scanner.nextLine();

        String censured = GenerateEmail(email.substring(0, email.indexOf('@')).length()) + email.substring(email.indexOf('@'));

        System.out.println(text.replace(email, censured));
    }

    private static String GenerateEmail(int length) {
        String result = "";

        for (int i = 0; i < length; i++){
           result += "*";
        }

        return result;
    }
}