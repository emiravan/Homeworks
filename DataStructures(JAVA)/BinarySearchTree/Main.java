package EXC2;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        BinarySearchTree tree = new BinarySearchTree();
        readFromFile(tree);

        Student newStudent = new Student(1001, "Ahmet", "Yılmaz", 85.5);
        tree.insert(newStudent);

        // Delete
        int studentIdToDelete = 1003;
        tree.delete(studentIdToDelete);

        System.out.println("Students:");
        tree.inOrder();
    }

    private static void readFromFile(BinarySearchTree tree) {
        try {
            File file = new File("students.txt");
            Scanner scanner = new Scanner(file);

            while (scanner.hasNextLine()) {
                String line = scanner.nextLine();
                String[] parts = line.split(", ");
                int studentId = Integer.parseInt(parts[0]);
                String name = parts[1];
                String surname = parts[2];
                double gradeAverage = Double.parseDouble(parts[3]);
                Student student = new Student(studentId, name, surname, gradeAverage);
                tree.insert(student);
            }
            scanner.close();
        } catch (FileNotFoundException e) {
            System.out.println("File Not Found.");
            e.printStackTrace();
        }
    }
}
