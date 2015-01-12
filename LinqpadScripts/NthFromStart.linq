<Query Kind="Program" />

void Main()
{
	// node1
	var node = new Node();
	node.value = 1;
	node.next = null;
	var head = node;
	
	// node2
	var node1 = new Node();
	node1.value = 2;
	node1.next = null;
	node.next = node1;
	node = node1;
	
	// node3
	node1 = new Node();
	node1.value = 3;
	node1.next = null;
	node.next = node1;
	node = node1;
	
	// node4
	node1 = new Node();
	node1.value = 4;
	node1.next = null;
	node.next = node1;
	node = node1;
	
	NthFromStart(1, head).value.Dump();	
}

// iterative
//Node NthFromStart(int n, Node curr){
//	var node = curr;
//	while(n > 1){
//		node = Tail(node);
//		n--;
//	}
//	return node;
//}

// recursive
Node NthFromStart(int n, Node curr){
	var node = curr;
	if(n > 1){
		node = Tail(curr);
		n = n-1;
		return NthFromStart(n, node);
	}
	return curr;
}

Node Tail(Node curr){
	if(curr != null){
		return curr.next;
	} 
	return null;
}

// Define other methods and classes here
public class Node{
	public int value;
	public Node next;
}