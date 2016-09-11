<Query Kind="Program" />

void Main()
{
	ReverseInput("abc").Dump("Reverse String");
}

// Define other methods and classes here
string ReverseInput(string input){
	if(input.Length == 1){
		return input;
	} else {
		return input[input.Length - 1] +  ReverseInput(input.Substring(0, input.Length - 1));
	}
}