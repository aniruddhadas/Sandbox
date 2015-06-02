<Query Kind="Program" />

void Main()
{
	var inp = new [] {"bat", "1tab", "cat"};
	FetchPalindromes(inp).Dump();
//	IsPalindrome("blackcalb").Dump();
//	Reverse("blac").Dump();
}

// Define other methods and classes here
IEnumerable<Tuple<string, IEnumerable<string>>> FetchPalindromes(string[] inp){
	var outList = new List<Tuple<string, IEnumerable<string>>>();
	foreach(var i in inp){
		// get possible centers
		for(int j = 0; j <= i.Length; j++){
			var first = i.Substring(0, j);//.Dump();
			var last = i.Substring(0 + j, i.Length - j);//.Dump();
			var revFirst = Reverse(first);
			
			// postpended
			var finalString = string.Format("{0}{1}{2}", first, last, revFirst);//.Dump();
			if(IsPalindrome(finalString)){
				if(inp.Any(x => x == revFirst)){
					outList.Add(new Tuple<string, IEnumerable<string>>(i, inp.Where(x => x == revFirst)));
				}
			}
			
			// if prepended
			var revLast = Reverse(last);
			var finalString1 = string.Format("{0}{1}{2}", revLast, first, last);//.Dump();
			if(IsPalindrome(finalString1)){
				if(inp.Any(x => x == revLast)){
					outList.Add(new Tuple<string, IEnumerable<string>>(i, inp.Where(x => x == revLast)));
				}
			}
		}
	}
	return outList;
}

string Reverse(string input){
	StringBuilder s = new StringBuilder();
	for(int i=0;i<input.Length;i++){
		s.Append(input[input.Length - 1 -i]);
	}
	
	return s.ToString();
}

bool IsPalindrome(string input){
	int i = input.Length/2 - 1;
	for(var j=0;j<=i;j++){
		if(input[j] != input[input.Length - 1-j]){
			return false;
		}
	}
	return true;
}