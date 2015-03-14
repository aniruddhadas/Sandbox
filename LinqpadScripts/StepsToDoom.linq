<Query Kind="Program" />

void Main()
{
	F(string.Empty, 3);
	F(string.Empty, 10);
}

// Define other methods and classes here
void F(string path, int n){
	if(n == 0)
	{
		(path).Dump();
		return;
	}
	
	if(n > 0){
		F(path + " 1", n - 1);
		F(path + " 2", n - 2);
	}
}