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
	int[] sourceArr = new int[] {23, 5, 4, 7, 2, 11};
	int sum = 20;

	
	Array.Sort(sourceArr);
	var listOfNumbers = new Stack<int>();
	GetSumSubArray(sourceArr, 0, listOfNumbers, sum, sum);
}

void GetSumSubArray(int[] sourceArr, int startIndex, Stack<int> currArray, int pendingsum, int sum){
	if(pendingsum==0){
		// print currArray
		currArray.Dump();
		currArray.Pop();
		return;
	}
	
	for(int x =startIndex;x<sourceArr.Length;x++){
		if(sourceArr[x] > pendingsum && currArray.Any()){
//			pendingsum.Dump("pendinsum");
//			sourceArr[x].Dump("element");
			currArray.Pop();
			return;
		}
		
		// add yourself to the array and push the buck along
		currArray.Push(sourceArr[x]);
		GetSumSubArray(sourceArr, x + 1, currArray, pendingsum - sourceArr[x], sum);
	}
}