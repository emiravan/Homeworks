import java.util.Scanner;

public class Main {
	
	public static void main(String[] args) {
	    int[] myList = {4, 2, 2, 8, 3, 3, 1};
	    int range = 9; 

	    int[] sortedArray = countingSort(myList, range);

	    for(int i=0;i<sortedArray.length;i++)
	    	System.out.println(sortedArray[i]);
	}
	
	public static int[] countingSort(int[] myList, int range) {
	    int[] counter = new int[range];
	    int i, j;
	    
	    for (i = 0; i < myList.length; i++) {
	        counter[myList[i]]++;
	    }

	    int[] sortedArray = new int[myList.length];
	    int index = 0;
	    for (i = 0; i < range; i++) {
	        while (counter[i] > 0) {
	            sortedArray[index] = i;
	            index++;
	            counter[i]--;
	        }
	    }

	    return sortedArray;
	}
	
	
	
	
	
	
	
}
