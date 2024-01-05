
public class main {

	public static void main(String[] args) {
        int[][] example = {
            {5, 3, 4, 6, 7, 8, 9, 1, 2},
            {6, 7, 2, 1, 9, 5, 3, 4, 8},
            {1, 9, 8, 3, 4, 2, 5, 6, 7},
            {8, 5, 9, 7, 6, 1, 4, 2, 3},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 9, 2, 4, 8, 5, 6},
            {9, 6, 1, 5, 3, 7, 2, 8, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 4, 5, 2, 8, 6, 1, 7, 9}
        };

        boolean isValidSudoku = isValid(example);
        if (isValidSudoku) {
            System.out.println("valid.");
        } else {
            System.out.println("not valid.");
        }
    }
	
	public static boolean isValid(int[][] sudoku) {
	    
	    for (int row = 0; row < 9; row++) {
	        boolean[] used = new boolean[9];
	        for (int col = 0; col < 9; col++) {
	            int value = sudoku[row][col];
	            if (value < 1 || value > 9 || used[value - 1]) {
	                return false; 
	            }
	            used[value - 1] = true;
	        }
	    }

	    for (int col = 0; col < 9; col++) {
	        boolean[] used = new boolean[9];
	        for (int row = 0; row < 9; row++) {
	            int value = sudoku[row][col];
	            if (value < 1 || value > 9 || used[value - 1]) {
	                return false;
	            }
	            used[value - 1] = true;
	        }
	    }

	    for (int gridRow = 0; gridRow < 3; gridRow++) {
	        for (int gridCol = 0; gridCol < 3; gridCol++) {
	            boolean[] used = new boolean[9];
	            for (int row = gridRow * 3; row < gridRow * 3 + 3; row++) {
	                for (int col = gridCol * 3; col < gridCol * 3 + 3; col++) {
	                    int value = sudoku[row][col];
	                    if (value < 1 || value > 9 || used[value - 1]) {
	                        return false;
	                    }
	                    used[value - 1] = true;
	                }
	            }
	        }
	    }

	    return true;
	}

}
