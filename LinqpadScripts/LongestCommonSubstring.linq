<Query Kind="Program" />

void Main()
{
	// test1
	var string1 = "ABAB";
	var string2 = "BABA";
	
	// test1
	string1 = "ABAAA";
	string2 = "AAA";

	// test2
	string1 = "AAA";
	string2 = "ABAAA";

	// test3
	string1 = "CCCCC";
	string2 = "ABAAA";

	// test4
	string1 = "BAAA";
	string2 = "AAAB";
	
	var fillUpMatrix = new int[string1.Length, string2.Length];
	FindLongestCommonSubstring(string1, string2, fillUpMatrix).Dump();
	fillUpMatrix.Dump();
}

// Define other methods and classes here
public int FindLongestCommonSubstring(string string1, string string2, int[,] fillUpMatrix){
	var ret = new List<char>();
	int z =0, xIndex=0, yIndex=0;
	for(int i=0;i<string1.Length;i++){
		for(int j=0;j<string2.Length;j++){
			if(string1[i] == string2[j]){
				if(i == 0 || j == 0) {
					fillUpMatrix[i, j] = 1;		
				} else {
					fillUpMatrix[i, j] = fillUpMatrix[i - 1, j - 1] + 1;	
				}
				
				if(fillUpMatrix[i,j] > z){
				    z = fillUpMatrix[i,j];
					xIndex = i;
					yIndex = j;
				}
			}		
		}
	}
//	xIndex.Dump("xindex");
//	z.Dump("z");
	// get the longest substring
	string1.Substring(xIndex - z + 1, z).Dump();
	
	return z;
}