<Query Kind="Program" />

void Main()
{
	var sentence = "this is a sentence";
	
}

// Define other methods and classes here
List<string> LongestConsecChar(string s){
	int count = 1;
	int len = s.Length - 1;
	
	char maxlong = s[0];
	int startPos = 0;
	int len = 1;
	
	while(count < len){
		count++;
		
		if(s[count] == s[count-1]){
			len = 2;
			maxlong = s[count];
		} else {
			startPos = 
		}
	}
}