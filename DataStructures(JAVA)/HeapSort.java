package Sortings;

public class HeapSort {

	public static void main(String[] args) {
		int[] arr = {8,2,5,3,4,7,6,1};
		
		for(int i=0;i<arr.length;i++) {
			System.out.print(arr[i]+"");
		}
		
		heapSort(arr);
		
		System.out.println("");
		
		for(int i=0;i<arr.length;i++) {
			System.out.print(arr[i]+"");
		}

	}
	
	static void heapify(int arr[],int N,int i) {
		
		int largest = i;
		int l=2*i+1;
		int r= 2*i+2;
		
		if(l<N&&arr[l]>arr[largest]) {
			largest = l;
		}
		
		if(r<N&&arr[r]>arr[largest]) {
			largest = r;
		}
		
		if(largest!=i) {
			int temp = arr[i];
			arr[i]=arr[largest];
			arr[largest]=temp;
			heapify(arr,N,largest);
		}
	}
	
	static void heapSort(int[] arr) {
		
		int N = arr.length;
		
		for(int i=N/2-1;i>=0;i--) {
			heapify(arr,N,i);
		}
		
		for(int i =N-1;i>0;i--) {
			
			int temp=arr[0];
			arr[0]=arr[i];
			arr[i]=temp;
			
			heapify(arr,i,0);
		}
	}
	

}
