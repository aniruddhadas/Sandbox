<Query Kind="Program" />

void Main()
{
	int[] arr = new int[] {10, 7, 4, 5, 6, 8, 6, 10};
	arr = new int[] {10, 7, 4, 5, 6, 8, 10};
	arr = new int[] {10};
	arr = new int[] {10, 8, 6};
	arr = new int[] {10, 0, 6};
	int index = GetMinIndex(arr, 0, arr.Length - 1).Dump();
	arr[index].Dump("Min Value");
}

// Define other methods and classes here
int GetMinIndex(int[] arr, int start, int end){
	int mid = (start + end)/2;
	if(mid == 0){
		return 0;
	}
	if(mid == arr.Length - 1){
		return mid;
	}
	
	if(arr[mid] < arr[mid-1] && arr[mid] < arr[mid + 1]){
		return mid;
	}
	
	if(arr[mid - 1] < arr[mid] && arr[mid] < arr[mid + 1]) {
		return GetMinIndex(arr, start, mid - 1);
	}
	
	if(arr[mid - 1] > arr[mid] && arr[mid] > arr[mid + 1]) {
		return GetMinIndex(arr, mid + 1, end);
	}
	
	throw new Exception("Not Possible");
}