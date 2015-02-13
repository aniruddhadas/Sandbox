<Query Kind="Program" />

void Main()
{
	var entries = File.ReadAllLines(@"c:\temp\graph.txt")
					.Select(x => new {
						Nodes = x.Split(new [] {" "}, StringSplitOptions.RemoveEmptyEntries)
					});
	
	// generate list of edges
	var listOfEdges = new List<Edge>();
	var listOfNodes = new HashSet<string>();
	foreach(var entry in entries){
		for(int i=1;i<entry.Nodes.Count();i++){
			
			listOfEdges.Add(new Edge{
				fromNode = entry.Nodes[0],
				toNode = entry.Nodes[i]
			});
			
			listOfNodes.Add(entry.Nodes[0]);
			listOfNodes.Add(entry.Nodes[1]);
		}
	}
	listOfEdges.Dump();
//	listOfNodes.Dump();
	
	foreach(var node in listOfNodes){
		StringBuilder output = new StringBuilder();
//		output.Append(node);
//		node.Dump();
		Dependencies(node, listOfEdges, output);
		string.Join("", output.ToString().ToCharArray().OrderBy(x => x).Distinct()).Dump("Node: "+node);
	}
}

public class Edge {
	public string fromNode;
	public string toNode;
}

// Define other methods and classes here
public void Dependencies(string node, List<Edge> listOfEdges, StringBuilder output){
	
	var outEdges = listOfEdges.Where(x => x.fromNode == node);
	
	// as long as there is an out edge
	foreach(var outEdge in outEdges){
		output = output.Append(outEdge.toNode);
//		outEdge.toNode.Dump();
		Dependencies(outEdge.toNode, listOfEdges, output);
	}
}