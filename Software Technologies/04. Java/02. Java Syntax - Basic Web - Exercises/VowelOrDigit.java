import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[]args){
       String vowels = "AEIOUY";

       java.util.Scanner scanner = new java.util.Scanner(System.in);

       char input = scanner.next().charAt(0);

       if (vowels.indexOf(input) >= 0 || vowels.toLowerCase().indexOf(input) >= 0){
           System.out.print("vowel");
       } else if (Character.isDigit(input)) {
           System.out.print("digit");
       } else {
           System.out.print("other");
       }
    }
}
