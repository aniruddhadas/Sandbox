<Query Kind="Program" />

void Main()
{
	IsPalindrome("ABCA").Dump();
	IsPalindrome("A!#A").Dump();
	IsPalindrome("A!#B").Dump();
	IsPalindrome("A man, a plan, a canal, Panama!".ToLower()).Dump();
	IsPalindrome("A man, a plan, a canal, Panamas!".ToLower()).Dump();
}

// Define other methods and classes here
bool IsPalindrome(string input){
	int len = input.Length;
	var startIndex = 0;
	int endIndex = len - 1;
	
	while(true){
		if(startIndex == endIndex){
			return true;
		}
		
		char firstChar = input[startIndex];
		if(!char.IsDigit(firstChar) && !char.IsLetter(firstChar)){
			
			startIndex++;
			continue;
		}
		
		char lastChar = input[endIndex];
		if(!char.IsDigit(lastChar) && !char.IsLetter(lastChar)){
			endIndex--;
			continue;
		}
		
		if(firstChar != lastChar){
			return false;
		}
		
		if(firstChar == lastChar){
			if(startIndex + 1 == endIndex){
				return true;
			}
		
			startIndex++;
			endIndex--;
		}
	}
}