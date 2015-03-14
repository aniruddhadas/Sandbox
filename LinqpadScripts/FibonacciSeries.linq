<Query Kind="Program" />

void Main()
{
	F(10).Dump();
}

// Define other methods and classes here
int F(int n){
	if(n == 1 || n == 2){
		return n;
	}
	var val1 = F(n - 1);
	var val2 = F(n - 2);
	return val1 + val2;
}