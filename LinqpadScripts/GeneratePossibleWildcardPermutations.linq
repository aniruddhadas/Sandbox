<Query Kind="Program" />

void Main()
{
	string inp = "1?0?";
	GeneratePossibleStrings(inp);
}

// Define other methods and classes here
IEnumerable<string> GeneratePossibleStrings(string input){
	var qCounts = input.ToCharArray().Where((x, i) => x == '?').Count();//.Dump();
	var positions = input.ToCharArray().Select((x, i) => new {x, i}).Where(y => y.x == '?').Select(y => y.i);//.Dump();
	// for each position you need to fill in 0 and 1 starting at the 0 index
	FillArray(positions.ToArray(), 0, new StringBuilder(input));
	return null;
}

void FillArray(int[] qMarksIndex, int currIndex, StringBuilder input){
	if(currIndex == qMarksIndex.Count()){
		input.ToString().Dump();
		return;
	}
		// set the currIndex in qMarkIndex in string to 0 and run
	input[qMarksIndex[currIndex]] = '0';
	currIndex = currIndex + 1;
	FillArray(qMarksIndex, currIndex, input);
	currIndex = currIndex - 1;
	// set the currIndex in qMarkIndex in string to 1 and run
	input[qMarksIndex[currIndex]] = '1';
	currIndex = currIndex + 1;
	FillArray(qMarksIndex, currIndex, input);
	currIndex = currIndex - 1;
}