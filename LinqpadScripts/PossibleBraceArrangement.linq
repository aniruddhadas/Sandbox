<Query Kind="Program" />

void Main()
{
	PrintPossibleBraceArrangements(3);
}

// Define other methods and classes here
void PrintPossibleBraceArrangements(int n){
	var possibleBrances = n * 2;
	PrintPossibleBraceArrangements(possibleBrances, 0, 0, string.Empty);
}

void PrintPossibleBraceArrangements(int totalPossibleBrances, int openBraces, int closedBraces, string bracesString){
	if((openBraces + closedBraces) == totalPossibleBrances){
		bracesString.Dump();
		return;
	}
	
	if(openBraces < closedBraces){
		throw new Exception("Impossible State");
	}
	
	if(openBraces != closedBraces){
		PrintPossibleBraceArrangements(totalPossibleBrances, openBraces, closedBraces + 1, bracesString + ")");
	}
	
	if(openBraces < totalPossibleBrances / 2){
		// open a new braces and keep going
		PrintPossibleBraceArrangements(totalPossibleBrances, openBraces + 1, closedBraces, bracesString + "(");
	}
	
}