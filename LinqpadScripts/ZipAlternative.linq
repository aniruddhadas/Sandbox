<Query Kind="Program" />

void Main()
{
	var arr1 = "abc".ToCharArray();
	var arr2 = "def".ToCharArray();
	
	// new zip
	arr1.Zip1(arr2, (a, b) => (a + " " + b)).Dump();
	
	// regular zip
	arr1.Zip(arr2, (a, b) => (a + " " + b)).Dump();
}

// Define other methods and classes here
static class Enumerable 
{ 
    public static IEnumerable<TResult> Zip1<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> func) 
    { 
        return first
					.Select((x, i) => new { X = x, I = i })
					.Join(second.Select((x, i) => new { X = x, I = i }), o => o.I, i => i.I, (o, i) => func(o.X, i.X)); 
    } 
}