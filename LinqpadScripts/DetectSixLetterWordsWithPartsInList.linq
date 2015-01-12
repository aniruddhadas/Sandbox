<Query Kind="Program" />

void Main()
{
	var dictStrings1 = File
						.ReadAllText(@"C:\Users\and\Downloads\wordlist.txt", Encoding.UTF8)
						.;
	string replaceWith = "";
	var dictStrings = File.ReadLines(@"C:\Users\and\Downloads\wordlist.txt", Encoding.UTF8)
//						.AsParallel()
						.Select(x => System.Text.Encoding.ASCII.GetString(System.Text.Encoding.ASCII.GetBytes(x)))
						.Where(x => x.Length <= 6)
//						.Take(5)
//						.Dump()
						.ToArray();
	Array.Sort(dictStrings);
//	dictStrings.Dump();
	int count = 0;
	for(var x = 0; x < dictStrings.Length; x++){
		for(var y = x; y < dictStrings.Length; y++){
//			dictStrings[x].Dump();
//			dictStrings[y].Dump();
			var lookupString = dictStrings[x] + dictStrings[y];
			lookupString.Dump();
			if(lookupString.Length != 6) {
				continue;
			}
			var index = Array.BinarySearch(dictStrings, lookupString);
			if(index > 0){
				count++;
				dictStrings[x].Dump("x"); 
				dictStrings[y].Dump("y");
				lookupString.Dump("FoundString");
//				index.Dump("index");
			}
		}
	}
	count.Dump();
}

// Define other methods and classes here