<Query Kind="Program" />

void Main()
{
	var data = @"first:ABC
	first:HIJ 
	sec:HIJ 
	sec:KLM 
	third:NOP 
	fourth:ABC 
	fourth:QRS 
	first:DEF 
	fifth:KLM 
	fifth:TUV";
	
	var parseddata = data.Split(new [] {Environment.NewLine}, StringSplitOptions.None)
	.Select(x => x.Trim())
	.Select(x => new {Customer = x.Split(':')[0], Item = x.Split(':')[1]})
	.Dump();
	
	var strongConnections = parseddata
								.Join(parseddata, x => x.Customer, y => y.Customer, (x, y) => new {Item1 = x.Item , Customer = x.Customer, Item2 = y.Item})
								.Where(x => x.Item1 != x.Item2)
								.Select(x => new {Item1 = x.Item1, Item2 = x.Item2})
								.Select(x => {
									if(x.Item1.CompareTo(x.Item2) < 0){
										return new {Item1 = x.Item1, Item2 = x.Item2};
									} else {
										return new {Item1 = x.Item2, Item2 = x.Item1};
									}
								})
								.OrderBy(x => x.Item1)
								.ThenBy(x => x.Item2)
								.Distinct()
								.Dump();
	var allConnections = parseddata
								.Join(parseddata, x => x.Customer, y => y.Customer, (x, y) => new {Item1 = x.Item , Customer = x.Customer, Item2 = y.Item})
								.Where(x => x.Item1 != x.Item2)
								.Dump();
}

// Define other methods and classes here