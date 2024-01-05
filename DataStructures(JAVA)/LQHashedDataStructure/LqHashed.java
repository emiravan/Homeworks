package EXC1;

public class LqHashed {
	int N;//max number of nodes in the structure;
	int n=0;//number of nodes in the structure like next
	int defQ=9967;
	double ldf=0.75;//loading factor
	Data deleted; //dummy node V2, V1=null
	private Data[] data; //primary storage array
	
	public LqHashed(int lenght)
	{
		int pct=(int)(1/ldf-1)*100;
		N=fkp3(lenght, pct);
		data=new Data[N];
		deleted=new Data("","");
		for(int i=0;i<N;i++)
			data[i]=null; //all nodes are set v1(null) in initialization
	}
	public boolean insert(Data newData)
	{
		
		boolean hit=false;
		int pass,q,offset,ip;
		int pk=strToInt(newData.getId());//preprocess the key
		if((double) n/N<ldf)//insert the node
		{
			pass=0;
			q=pk/N;
			offset=q;
			ip=pk%N;
			if(q%N==0)
				offset=defQ;
			while(pass<n)
			{
				if(data[ip]==null||data[ip]==deleted)
				{
					hit=true;
					break;
				}
				ip=(ip+offset)%N; //collusion occured
				pass++;
			}
			if (hit)
			{
				data[ip]=newData.deepCopy();
				n++;
				return true;
			}
			else
			{
				return false;
			}
		}
		return false;
		
	}
	
	public Data fetch(String tKey)
	{
		boolean hit=false;
		int pass,q,offset,ip;
		int pk=strToInt(tKey);//preprocess the key
		pass=0;
		q=pk/N;
		offset=q;
		ip=pk%N;
		if(q%N==0)
			offset=defQ;
		while(pass<N)
		{
			if(data[ip]==null)//node not found in the structure
				break;
			if(data[ip].getId().equals(tKey))//node found
			{
				hit=true;
				break;
			}
			ip=(ip+offset)%N; //collusion occured
			pass++;
		}
		if (hit)
			return data[ip].deepCopy();
		return null;
	}
	
	public boolean delete(String tKey)
	{
		boolean hit=false;
		int pass,q,offset,ip;
		int pk=strToInt(tKey);//preprocess the key
		pass=0;
		q=pk/N;
		offset=q;
		ip=pk%N;
		if(q%N==0)
			offset=defQ;
		while(pass<N)
		{
			if(data[ip]==null)//node not found in the structure
				break;
			if(data[ip].getId().equals(tKey))//node found
			{
				hit=true;
				break;
			}
			ip=(ip+offset)%N; //collusion occured
			pass++;
		}
		if (hit)
		{
			data[ip]=deleted;
			n--;
			return true;
		}
		return false;
	}
	
	public boolean update(String tKey,Data newData)
	{
		if(!delete(tKey))
			return false;
		else if(!insert(newData))
			return false;
		return true;
	}
	public void showAll()
	{
		for(int i=0;i<N;i++)
			if(data[i]!=null&&data[i]!=deleted)
				System.out.println(data[i].toString());
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
}
