<Query Kind="Program" />

void Main()
{
	var timer = new Stopwatch();
	timer.Start();
	
	// #1 method
//	var dictStrings = File.ReadLines(@"C:\Users\and\Downloads\wordlist.txt")
////						.Take(10)
////						.Dump()
//						;
//	
//	var sortedStringsDictionary = dictStrings
//									.GroupBy(x => string.Join(string.Empty, x.ToCharArray().OrderBy(y => y)))
//									.Select(x => new {
//														Key = x.Key,
//														Count = x.Count()
//														});
//	// detemining the max in the count column
//	int max = 0;
//	string maxKey = string.Empty;
//	
//	foreach(var key in sortedStringsDictionary){
//		if(max < key.Count){
//			max = key.Count;
//			maxKey = key.Key;
//		}
//	}
//	
//	dictStrings
//		.Where(x => string.Join(string.Empty, x.ToCharArray().OrderBy(y => y)) == maxKey)
//		.Dump();
//	var lookupString = "AAAAAAAAAAAAAAAAAAAAAAAAASAAAAAAAASDDXSXXXXXXXX";
//	dictStrings.Contains(CalculateMD5Hash(lookupString).Dump()).Dump();
	
	// #2 method
//	File.ReadAllLines(@"C:\Users\and\Downloads\wordlist.txt")
//		.GroupBy(w => String.Concat(w.OrderBy(c => c)))
//		.Where(g => g.Count() > 1)
//		.ToList().ForEach(g => Console.WriteLine(String.Join(" ", g)));
		
	timer.Stop();
	timer.Elapsed.Dump();
	
}

// Define other methods and classes here
