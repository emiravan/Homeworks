package EXC1;

public class UnsortedArray {
	private Data[] myArray;
	private int size;
	private int next;
	public UnsortedArray(int max) {
		this.myArray = new Data[max];
		this.size = max;
		this.next=0;
	}
	public String printArr()
	{
		String retStr="";
		for(int i=0;i<this.size;i++)
			if (myArray[i]!=null)
				retStr=retStr+myArray[i].toString()+"\n";
		return retStr;
	}
	
	public boolean insert(Data newData)
	{
		int pKey=strToInt(newData.getId());
		int pIndex=pKey%size;
		if (myArray[pIndex]==null)
		{
			myArray[pIndex]=newData;
			next++;
			return true;
		}
		else
		{
			//collusion occured
			//check with linear probing collusion;
			System.out.println("collusion occured,checking with linear probing collusion algo");
			int getLoc=linearProbing(pIndex);
			if (getLoc!=-1)
			{
				myArray[getLoc]=newData;
				return true;
			}
				
		}
		return false;
			
			
	}
	private int linearProbing(int pIndex) {
		// TODO Auto-generated method stub
		int i=pIndex+1;
		if (i>=size)
			return -1;
		int t=0;
		while(myArray[i]!=null&&t<this.size)
		{
			i++;
			t++;
			i=i%this.size;
		}
		if (t<this.size)
			return i;
		return -1;
	}
	public boolean delete(String key)
	{
		int pKey=strToInt(key);
		int pIndex=pKey%size;
		if (myArray[pIndex].getId().equals(key))
		{
			myArray[pIndex]=null;
			return true;
		}
		return false;	
	}
	
	public Data fetch(String key)
	{
		int pKey=strToInt(key);
		int pIndex=pKey%size;
		if (myArray[pIndex]!=null)
		{
			if(myArray[pIndex].getId().equals(key))
				return myArray[pIndex];
		}
		return null;
			
			
	}
	
	public static int strToInt(String aKey)
	{
		int pKey=0;
		int n=0,cn=0;
		char[] c=aKey.toCharArray();
		int grp=0;
		while(cn<aKey.length())
		{
			grp=grp<<8;
			grp=grp+c[cn];
			cn++;
			if(n==4||cn==aKey.length())
			{
				pKey=pKey+grp;
				n=0;
				grp=0;
			}
			n++;
		}
		return Math.abs(pKey);
	}

}
