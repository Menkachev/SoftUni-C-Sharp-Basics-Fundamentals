import com.sun.org.apache.xpath.internal.operations.Equals;

import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[]args){
        Scanner scanner = new Scanner(System.in);

        String[] firstArr = scanner.nextLine().trim().split("\\s");
        String[] secondArr = scanner.nextLine().trim().split("\\s");

        if (firstArr[0].length() == 0 || secondArr[0].length() == 0){
            return;
        }
        else  if (firstArr[0].length() == 0){
            PrintArray(secondArr);
            return;
        }
        else if (secondArr[0].length() == 0){
            PrintArray(secondArr);
            return;
        }

        boolean areEquals = false;
        boolean isFirstBigger = true;

        for (int i = 0; i < Math.min(firstArr.length, secondArr.length); i++) {
            if (firstArr[i].equals(secondArr[i])) {
                areEquals = true;
                continue;
            }

            isFirstBigger = (firstArr[i].charAt(0) > secondArr[i].charAt(0)) ? true : false;
            break;
        }

            if (areEquals){
                isFirstBigger = firstArr.length > secondArr.length ? true : false;
            }

            if (isFirstBigger){
                PrintArray(secondArr);
                PrintArray(firstArr);
            }
            else {
                PrintArray(firstArr);
                PrintArray(secondArr);
            }
        }

    private static void PrintArray(String[] arr) {
        for (int i = 0; i < arr.length; i++){
            System.out.print(arr[i]);
        }

        System.out.println();
    }
}