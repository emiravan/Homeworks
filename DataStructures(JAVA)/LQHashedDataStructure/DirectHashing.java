package EXC1;

public class DirectHashing {

	public static void main(String[] args) {

		//int optStorageSize=fkp3(2,33);
		int optStorageSize=5;
		System.out.println(optStorageSize);
		UnsortedArray myArr=new UnsortedArray(optStorageSize);
		String keyField="aa";
		String name="Cagatay Tulu";
		Data myData=new Data(keyField, name);
		if (myArr.insert(myData))
			System.out.println("data insert Success");
		else
			System.out.println("data insert Failed");
		keyField="aa";
		name="osman";
		myData=new Data(keyField, name);
		if (myArr.insert(myData))
			System.out.println("data insert Success");
		else
			System.out.println("data insert Failed");
		keyField="cc";
		name="osman";
		myData=new Data(keyField, name);
		if (myArr.insert(myData))
			System.out.println("data insert Success");
		else
			System.out.println("data insert Failed");	
		keyField="cc";
		name="osman3";
		myData=new Data(keyField, name);
		if (myArr.insert(myData))
			System.out.println("data insert Success");
		else
			System.out.println("data insert Failed");		
		
		System.out.println(myArr.printArr());
		System.out.println(myArr.fetch("aa"));
		
	}
	
	public static int getNearestPrime(int N)
	{
		for(int i=N;i<2*N;i++)
		{
			if (isPrime(i))
				return i;
		}
		return 0;
	}
	public static boolean isPrime(int N)
	{
		int rootN=(int)Math.sqrt(N);
		for(int i=2;i<=rootN;i++)
		{
			if (N%i==0)
				return false;
		}
		return true;
	}
	public static int fkp3(int n, int pct)
	{
		int N=n+(int)(n*pct/100);
		boolean isFkp3=false;
		int i=N+1;
		while (!isFkp3)
			if (isPrime(i))
			{
				if((i-3)%4==0)
					return i;
				else
					i++;
			}
			else
				i++;
		return 0;
		
	}
	


}

