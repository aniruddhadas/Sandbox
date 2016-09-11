<Query Kind="Program" />

void Main()
{
	var q = new Queue<string>();
	q.Push("a");
	q.Push("a");
	q.Push("b");
	q.Pop().Dump();
	q.Push("c");
	q.Push("d");
	q.Pop().Dump();
	q.Pop().Dump();
	q.Pop().Dump();
	q.Pop().Dump();
}

// Define other methods and classes here
class Queue<T>{
	Stack<T> firstStack;
	Stack<T> secondStack;
	
	public Queue(){
		firstStack = new Stack<T>();
		secondStack = new Stack<T>();
	}
	
	public T Pop(){
		if(secondStack.Count != 0){
			return secondStack.Pop();
		}
		
		if(firstStack.Count == 0){
			// means there are no elements in either stack
			throw new Exception("No Elements");
		}
		
		// move all the contents from the first stack into the second stack
		while(firstStack.Count != 0){
			secondStack.Push(firstStack.Pop());
		}
		
		return secondStack.Pop();
	}
	public void Push(T incoming){
		firstStack.Push(incoming);
	}
}