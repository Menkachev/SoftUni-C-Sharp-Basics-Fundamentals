import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[]args){
        Scanner scan = new Scanner(System.in);

        double firstNum = scan.nextDouble();
        double secondNum = scan.nextDouble();

        System.out.printf("Sum=%.2f", firstNum + secondNum);
    }
}
