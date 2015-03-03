<Query Kind="Program" />

void Main()
{
	int[] sourceArr = new int[] {2, 1001, -999, 999, -999, 5, 7, 11, 2, 4};
	int countLen = sourceArr.Length - 1;
	int maxSum=int.MinValue;
	while(countLen >= 0){
		for(int x = 0; x < (sourceArr.Length - countLen); x++){
			int currSum = Sum(sourceArr, x, x + countLen);
			
			if(currSum > maxSum){
				maxSum = currSum;
			}
		}
		countLen--;
	}
	maxSum.Dump();
}

// Define other methods and classes here
int Sum(int[] sourceArr, int startPos, int endPos){
	int sum = sourceArr[startPos];
	for(int x = startPos + 1; x <= endPos; x++){
		sum = sourceArr[x] + sum;
	}
	return sum;
}
