package src.ds.algo;

public class LengthOfLastWord
{


	public boolean isValid(char ch)
	{
		if( (ch == ' ') || (ch == ',') )
			return false;
		return true;
	}





















	//warmup
	//"hello world"
	//"this  "
	public int lengthOfLastWord(final String a) {
		int length = 0;
		int lastLength = 0;
		for(int i =0; i< a.length(); i++){
			if(a.charAt(i) == ' '){
				if(length > 0)
					lastLength = length;
				length = 0;
			}else{
				length++;
			}
		}
		if(length ==0)
			return lastLength;
		else
			return length;
	}

}
