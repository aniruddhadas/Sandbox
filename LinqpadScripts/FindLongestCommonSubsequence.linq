<Query Kind="Program" />

void Main()
{
//	FindLongestCommonSubstring("ABABC", "BABCA");
	FindLongestCommonSubsequence("ABABC", "B").Dump();
	FindLongestCommonSubsequence("ABABC", "CBACBA").Dump();
}

string FindLongestCommonSubsequence(string string1, string string2){
	// allocate a matrix of size n x m
	int[,] lookUpMatrix = new int[string1.Length + 1, string2.Length + 1];
	// filling the matrix
	for(int i=1;i<=string1.Length;i++){
		for(int j=1;j<=string2.Length;j++){
			if(string1[i-1] == string2[j-1]){
				lookUpMatrix[i,j] = lookUpMatrix[i-1, j-1] + 1;
			} else {
			    lookUpMatrix[i,j] = Math.Max(lookUpMatrix[i,j-1], lookUpMatrix[i-1,j]);
			}
		}
	}
	
	lookUpMatrix.Dump();
	return backtrack(lookUpMatrix, string1, string2, string1.Length, string2.Length);
//	return string.Empty;
}

string backtrack(int[,] lookupmatrix, string string1, string string2, int i, int j){
    if(i == 0 || j == 0)
        return string.Empty;
    else if(string1[i - 1] == string2[j - 1])
        return backtrack(lookupmatrix, string1, string2, i-1, j-1) + string1[i - 1];
    else
        if(lookupmatrix[i,j-1] > lookupmatrix[i-1,j])
            return backtrack(lookupmatrix, string1, string2, i, j-1);
        else
            return backtrack(lookupmatrix, string1, string2, i-1, j);
}
