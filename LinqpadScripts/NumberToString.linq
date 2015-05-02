<Query Kind="Program" />

void Main()
{

	GetString(1).Dump();	
	GetString(11).Dump();	
	GetString(91).Dump();	
	GetString(9).Dump();	
	
	GetString(1234).Dump();	
	GetString(934).Dump();	
	GetString(900).Dump();	
	GetString(512).Dump();	
	
	GetString(21234).Dump();	
	GetString(121234).Dump();	
	GetString(5121234).Dump();	
	GetString(25121234).Dump();	
	GetString(100121234).Dump();	
}

// Define other methods and classes here
string GetString(int num){
	var numToString = new Dictionary<int, string>();
	numToString.Add(1, "one");
	numToString.Add(2, "two");
	numToString.Add(3, "three");
	numToString.Add(4, "four");
	numToString.Add(5, "five");
	numToString.Add(6, "six");
	numToString.Add(7, "seven");
	numToString.Add(8, "eight");
	numToString.Add(9, "nine");
	numToString.Add(10, "ten");
	numToString.Add(11, "eleven");
	numToString.Add(12, "twelve");
	numToString.Add(13, "thirteen");
	numToString.Add(14, "forteen");
	numToString.Add(15, "fifteen");
	numToString.Add(16, "sixteen");
	numToString.Add(17, "seventeen");
	numToString.Add(18, "eighteen");
	numToString.Add(19, "ninteen");
	numToString.Add(20, "twenty");
	numToString.Add(30, "thirty");
	numToString.Add(40, "forty");
	numToString.Add(50, "fifty");
	numToString.Add(60, "sixty");
	numToString.Add(70, "seventy");
	numToString.Add(80, "eigthy");
	numToString.Add(90, "ninty");
	
	var numstr = num.ToString();
	var len = numstr.Length;
	var returnVal = new StringBuilder();
	var tempnum = num;
	while(tempnum > 1000) {
		
		var trimmednum = (int) (tempnum / Math.Pow(1000, (len - 1)/3));
		returnVal.Append(NumberToString(numToString, trimmednum));
		var partialString = GetString(numToString, len - 1);
		
		returnVal.Append(partialString);
		returnVal.Append(" ");
//		returnVal.Dump();
		tempnum = (int)(tempnum % Math.Pow(1000, (len - 1)/3));
		len = len - 3;
	}
	
	returnVal.Append(" ");
	returnVal.Append(NumberToString(numToString, tempnum));
	
	return returnVal.ToString();
}

string GetString(Dictionary<int, string> numToString, int len){
	switch(len/3){
		case 1:
			return " thousand";
		case 2:
			return " million";
	}
	return string.Empty;
}

string NumberToString(Dictionary<int, string> numToString, int num){
	if(numToString.ContainsKey(num)){
		return numToString[num];
	}
	if(num < 100){
		return numToString[(num/10) * 10] + " " + numToString[num % 10]; 
	}
	
	if(num%100 == 0){
		return numToString[num/100] + " hundred"; 
	
	} else {
		return numToString[num/100] + " hundred " + NumberToString(numToString, num%100); 
	}
}