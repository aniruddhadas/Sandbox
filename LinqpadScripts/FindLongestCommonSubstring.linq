<Query Kind="Program" />

void Main()
{
//	FindLongestCommonSubstring("ABABC", "BABCA");
	FindLongestCommonSubstring("ABABC", "B").Dump();
	
	// finding longest palindrome in a string
	FindLongestCommonSubstring("ABABC", "CBABA").Dump();
}

string FindLongestCommonSubstring(string string1, string string2){
	// allocate a matrix of size n x m
	int[,] lookUpMatrix = new int[string1.Length + 1, string2.Length + 1];
	int z = 0;
	string ret = null;
	// filling the matrix
	for(int i=1;i<=string1.Length;i++){
		for(int j=1;j<=string2.Length;j++){
			if(string1[i-1] == string2[j-1]){
				lookUpMatrix[i,j] = lookUpMatrix[i-1, j-1] + 1;
			}
			
			if(lookUpMatrix[i,j] > z){
				z = lookUpMatrix[i,j];
				ret = string1.Substring(i - z, z);
//				ret.Dump();
			}
			
			// this is for all substring
//			if(lookUpMatrix[i,j] == z){
//				
//				ret = ret + string1.Substring(i - z, z);
//				ret.Dump();
//			}
		}
	}
	
	// determine the longest substring
	lookUpMatrix.Dump();
	
	return ret;
}