<Query Kind="Program" />

void Main()
{
	int[] arr = new int[] {1, 2, 3, 5, 4, 6};
//	int[] arr = new int[] {1, 7, 3, 6, 4, 3};
	FindSubset(0, arr, 0, 10, new Stack<int>());
}

// Define other methods and classes here
void FindSubset(int start, int[] arr, int currsum, int finalsum, Stack<int> goodElements){
	for(int i=start; i<arr.Length; i++){
		if((currsum + arr[start]) < finalsum){
			goodElements.Push(arr[start]);
			FindSubset(i+1, arr, currsum + arr[start], finalsum, goodElements);
			goodElements.Pop();
		} else if((currsum + arr[start]) == finalsum) {
			goodElements.Push(arr[start]);
			goodElements.Dump();
			goodElements.Pop();
			return;
		}
	}
}