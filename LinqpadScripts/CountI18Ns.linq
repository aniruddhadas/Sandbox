<Query Kind="Program" />

void Main()
{
	GenerateI18NStrings("careercup");
}

// Define other methods and classes here
void GenerateI18NStrings(string input){
	// possible i18ns sizes
	for(int i = 0; i < input.Length; i++){
		// possible starting positions
		for(int j=0; j < (input.Length - i); j++){
			string firstPart = input.Substring(0, j);//.Dump("1");
			string num = (i+1).ToString();//.Dump("2");
			string lastPart = input.Substring(j + i + 1, input.Length - j - i - 1);//.Dump("3");
			(firstPart + num + lastPart).Dump();
		}
	}
}