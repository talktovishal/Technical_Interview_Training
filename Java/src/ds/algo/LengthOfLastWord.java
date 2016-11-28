package src.ds.algo;

public class LengthOfLastWord
{
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
