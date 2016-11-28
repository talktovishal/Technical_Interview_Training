package src.ds.algo;

public class Palindrome
{
	//Given a string, determine if it is a palindrome, 
	//considering only alphanumeric characters and ignoring cases.
	public int isPalindrome(String a) {
		int start = 0;
		int end = a.length() -1;
		int N = a.length() -1;
		while(end > start){
			while(start <N && !Character.isLetterOrDigit(a.charAt(start))) start++;
			while(end >= 0 && !Character.isLetterOrDigit(a.charAt(end))) end--;
			//System.out.println("Print: " + start + "\t" + end);
			if(start >=N || end < 0)
				return 1;
			if(end > start) {
				if(Character.toLowerCase(a.charAt(start)) == Character.toLowerCase(a.charAt(end)))
				{
					start++; end--;
				}else{
					return 0;
				}
			}
		}
		return 1;
		//.Character.toLowerCase(char ch) 
		//!Character.isLetterOrDigit(char)
	}

	public static void main(String[] args) {
		Palindrome p = new Palindrome();
		System.out.println("Print: p.isPalindrome \t" + p.isPalindrome("A man, a plan, a canal: Panama"));
		System.out.println("Print: p.isPalindrome \t" + p.isPalindrome("race a car"));
		System.out.println("Print: p.isPalindrome \t" + p.isPalindrome(".,"));
		//A : 
	}

}
