<Query Kind="Program" />

void Main()
{
	// test1
//	int[] sourceArr = new int[] {1, 3, 5, 23, 2};
//	int sum = 8;
	
	// test2
//	int[] sourceArr = new int[] {23, 5, 4, 7, 2, 11};
//	int sum = 20;

	// test3
	int[] sourceArr = new int[] {999, 5, 7, 11, 2, 4};
	int sum = 24;

	var listOfNumbers = new Queue<int>();
	GetSumSubArray(sourceArr, sourceArr.Length - 1, listOfNumbers, 0, sum).Dump();
}

bool GetSumSubArray(int[] sourceArr, int startIndex, Queue<int> currArray, int currsum, int sum){
	if(currsum == sum){
		currArray.Dump();
		return true;	
	}
	
	// this means you have fallen off the start
	if(startIndex < 0){
		return false;
	}
	
	if((sourceArr[startIndex] + currsum) > sum){
		// then dequeue
		int endElement = currArray.Dequeue();
		return GetSumSubArray(sourceArr, startIndex, currArray, currsum - endElement, sum);
	} else {
		// then enqueue
		currArray.Enqueue(sourceArr[startIndex]);
		return GetSumSubArray(sourceArr, startIndex - 1, currArray, currsum + sourceArr[startIndex], sum);
	}
}