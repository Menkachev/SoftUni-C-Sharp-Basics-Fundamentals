import java.util.Scanner;

public class VariableInHexFormat {
    public static void main(String[]args){
        Scanner scanner = new Scanner(System.in);

        String hexNum = scanner.next();

        System.out.println(Integer.parseInt(hexNum, 16));
    }
}
