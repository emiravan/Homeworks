package study5;

import java.util.Scanner;

public class main {

	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);		
		int target,length;
		
		System.out.print("Enter array length: ");
		length=scanner.nextInt();
		int[] numbers = new int[length];
		for(int i=0;i<length;i++)
		{
			System.out.printf("Enter %d. number: ",i+1);
			numbers[i]=scanner.nextInt();
		}
		System.out.println("Is array sorted: "+isSorted(numbers, 0));
		System.out.print("Enter number to check if it is in array: ");
		target=scanner.nextInt();
		System.out.print("result: ");
		System.out.print(find(numbers,target,0));

	}
	static boolean isSorted(int[] arr,int index)
	{
		if(index==arr.length-1)
			return true;
		
		return arr[index] < arr[index+1] && isSorted(arr,index+1);
	}
	static boolean find(int[] arr,int target,int index)
	{
		if(index==arr.length)
			return false;
		return arr[index]==target || find(arr,target,index+1);
			
	}

}
