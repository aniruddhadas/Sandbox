<Query Kind="Program" />

void Main()
{
	var list = new List<Tuple<int, int>>(){
											new Tuple<int, int>(-2, -4),
											new Tuple<int, int>(0, 0),
											new Tuple<int, int>(10, 15),
											new Tuple<int, int>(5, 6),
											new Tuple<int, int>(7, 8),
											new Tuple<int, int>(-10, -30),
											};
	var referencePoint = new Tuple<int, int>(5, 5);
	var count = 2;
	FindKClosest(list, referencePoint, count).Dump();
}

// Define other methods and classes here
SortedList FindKClosest(List<Tuple<int, int>> points, Tuple<int, int> referencePoint, int count)
{
	SortedList sortedList = new SortedList();
	foreach(var point in points){
		
		var distance = Distance(point, referencePoint);
		int counter = sortedList.Count - 1;
		
		if(counter < count - 1){
			sortedList.Add(distance, point);
			continue;
		}
		
		if((long)sortedList.GetKey(counter) > distance){
			sortedList.RemoveAt(counter);
			sortedList.Add(distance, point);
		}
	}
	
	return sortedList;
}

long Distance(Tuple<int, int> a, Tuple<int, int> b){
	return (a.Item1 - b.Item1)*(a.Item1 - b.Item1) + (a.Item2 - b.Item2)*(a.Item2 - b.Item2);
}