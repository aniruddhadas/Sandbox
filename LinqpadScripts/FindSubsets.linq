<Query Kind="Program" />

void Main()
{
	FindSubsets(4, string.Empty);
}

// Define other methods and classes here
void FindSubsets(int number, string outstring){
	if(number == 0){
		Console.WriteLine(outstring);
	}
	for(int i=1;i<=number;i++){
		FindSubsets(number - i, outstring + " " + i);
	}
}	