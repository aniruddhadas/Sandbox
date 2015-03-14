<Query Kind="Program" />

void Main()
{
	string stringArray = "ABC";
	int length = 9;
	Generate(stringArray, length);
}

void Generate(string stringArray, int length){
	int counter = 0;
	int paddedlength = 1;
	while(true){
		int loopCounter = (int)Math.Pow(stringArray.Length, paddedlength);
		for(int i=0;i<loopCounter;i++){
			GenerateNthnary(i, stringArray.Length, stringArray, paddedlength).Dump();
			counter++;
			if(counter == length){
				return;
			}
		}
		paddedlength++;
	}
}

string GenerateNthnary(int number, int b, string stringArray, int paddedlength){
	StringBuilder outString = new StringBuilder();
	StringBuilder debugString = new StringBuilder();
	int modulo = number;
	while(true){
		debugString.Append(modulo%b);
		outString = outString.Insert(0, stringArray[modulo%b]);
		modulo = modulo/b;
		if(modulo == 0){
			break;
		}
	}
	if(outString.Length != paddedlength){
		int outLen = outString.Length;
		for(int j=0;j<(paddedlength - outLen);j++){
			outString = outString.Insert(0, stringArray[0]);	
		}
	}
	return outString.ToString();
}