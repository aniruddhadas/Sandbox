<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Test();
	"4".Dump();
	
	//try1
	var task = Task.Delay(1000);
	task.Wait();
	//try2
//	Thread.Sleep(2000);
	"5".Dump();
}

// Define other methods and classes here
private static async Task DelayAsync()
{
	"3".Dump();
	await Task.Delay(1000);
	"1".Dump();
}
// This method causes a deadlock when called in a GUI or ASP.NET context.
public static async void Test()
{
	// Start the delay.
	var delayTask = DelayAsync();
	"2".Dump();
	
	// Wait for the delay to complete.
	// 2 ways
	await delayTask;
//	delayTask.Wait();
}