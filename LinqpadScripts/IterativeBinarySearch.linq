<Query Kind="Program" />

void Main()
{
	var arr = new int[]{2, 4, 5, 6, 10, 12, 15};
	int lookup = 15;
	LookupIndex(arr, 0, arr.Length - 1, lookup).Dump();
}

// Define other methods and classes here
int LookupIndex(int[] arr, int start, int end, int search){
	while(start <= end){
		var mid = (start + end) /2;
	
		if(arr[mid] == search){
			return mid;
		}
		
		if(search < arr[mid]){
			end = mid - 1;
		} else {
			start = mid + 1;
		}
	}
	return -1;
}