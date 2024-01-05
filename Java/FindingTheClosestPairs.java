import java.util.Scanner;

public class EXC2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int locations[][] = new int[8][2];
        double distances[] = new double[8];

        for (int i = 0; i < 8; i++) {
            System.out.print("Enter x " + (i + 1) + "th: ");
            locations[i][0] = scanner.nextInt();
            System.out.print("Enter y " + (i + 1) + "th: ");
            locations[i][1] = scanner.nextInt();

            int x = locations[i][0];
            int y = locations[i][1];
            distances[i] = Math.sqrt(x * x + y * y);
        }

        int minIndex = 0;
        double minDistance = distances[0];

        for (int i = 1; i < 8; i++) {
            if (distances[i] < minDistance) {
                minDistance = distances[i];
                minIndex = i;
            }
        }

        System.out.println("The smallest distance is" +
                " (" + locations[minIndex][0] + ", " + locations[minIndex][1] + "): " + minDistance);
    }
}