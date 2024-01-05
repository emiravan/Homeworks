package EXC1;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int maxCars = 1000; // Maximum number of cars
        
        // Creating the LqHashed data structure
        LqHashed lqHashed = new LqHashed(maxCars);
        
        while (true) {
            System.out.println("Choose an operation:");
            System.out.println("1. Add a new car");
            System.out.println("2. Display information about a car");
            System.out.println("3. Delete a car");
            System.out.println("4. Update car owner");
            System.out.println("5. Exit");
            
            int choice = scanner.nextInt();
            scanner.nextLine(); // Consume the newline
            
            switch (choice) {
                case 1:
                    System.out.println("Enter car ID:");
                    String carId = scanner.nextLine();
                    System.out.println("Enter owner's name:");
                    String ownerName = scanner.nextLine();
                    Data newCar = new Data(carId, ownerName);
                    boolean inserted = lqHashed.insert(newCar);
                    if (inserted) {
                        System.out.println("Car added successfully.");
                    } else {
                        System.out.println("Failed to add the car.");
                    }
                    break;
                case 2:
                    System.out.println("Enter car ID to display information:");
                    String idToDisplay = scanner.nextLine();
                    Data carInfo = lqHashed.fetch(idToDisplay);
                    if (carInfo != null) {
                        System.out.println("Car Information: " + carInfo.toString());
                    } else {
                        System.out.println("Car not found.");
                    }
                    break;
                case 3:
                    System.out.println("Enter car ID to delete:");
                    String idToDelete = scanner.nextLine();
                    boolean deleted = lqHashed.delete(idToDelete);
                    if (deleted) {
                        System.out.println("Car deleted successfully.");
                    } else {
                        System.out.println("Car not found or deletion failed.");
                    }
                    break;
                case 4:
                    System.out.println("Enter car ID to update owner:");
                    String idToUpdate = scanner.nextLine();
                    System.out.println("Enter new owner's name:");
                    String newOwnerName = scanner.nextLine();
                    Data updatedCar = new Data(idToUpdate, newOwnerName);
                    boolean updated = lqHashed.update(idToUpdate, updatedCar);
                    if (updated) {
                        System.out.println("Car owner updated successfully.");
                    } else {
                        System.out.println("Car not found or update failed.");
                    }
                    break;
                case 5:
                    System.out.println("Exiting program...");
                    scanner.close();
                    return;
                default:
                    System.out.println("Invalid choice. Please enter a valid option.");
            }
        }
    }
}
