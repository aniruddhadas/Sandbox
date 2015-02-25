<Query Kind="Program" />

void Main()
{
	var H = new Node
	{ 
		Name = "H",
		one = null,
		two = null
	};
	var I = new Node
	{ 
		Name = "I",
		one = null,
		two = null
	};
	var G = new Node
	{ 
		Name = "G",
		one = null,
		two = null
	};
	var K = new Node
	{ 
		Name = "K",
		one = null,
		two = null
	};
	var E = new Node
	{ 
		Name = "E",
		one = null,
		two = null
	};
	var F = new Node
	{
		Name = "F",
		one = H,
		two = I
	};
	var B = new Node
	{
		Name = "B",
		one = F,
		two = G
	};
	var D = new Node
	{
		Name = "D",
		one = K,
		two = null
	};
	var C = new Node
	{
		Name = "C",
		one = D,
		two = E
	};
	var A = new Node
	{
		Name = "A",
		one = B,
		two = C
	};
	Queue<Node> stack = new Queue<Node>();
	Inorder(stack, A);
	var curr = stack.Dequeue();
	var first = curr;
	Node next = null;
	while(stack.Count != 0){
		next = stack.Dequeue();
		curr.two = next;
		(curr.Name + "->" + next.Name).Dump();
		curr = next;
	}
	// last link
	next.two = first;
	(next.Name + "->" + first.Name).Dump();
}

public void Inorder(Queue<Node> stack, Node node){
	if(node.one != null){
		Inorder(stack, node.one);
//		var poped = stack.Pop();
//		(poped.Name + "->" + node.Name).Dump("Left");
//		poped.two = node;
//		poped.one = null;
	}
	stack.Enqueue(node);
	if(node.two != null){
		Inorder(stack, node.two);
//		var poped = stack.Pop();
//		(node.Name + "->" + poped.Name).Dump("Right");
//		node.two = poped;
//		node.one = null;
	}
}

// Define other methods and classes here
public class Node{
	public string Name;
	public Node one;
	public Node two;
}