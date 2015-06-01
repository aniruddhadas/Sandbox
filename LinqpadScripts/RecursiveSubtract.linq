<Query Kind="Program" />

void Main()
{
	int[] s_a = {9, 2, 0, 0, 1, 1};
	int[] s_b = {4, 6, 0, 1};
	var res = diff(s_a, s_b, 0).Dump();
}

// Define other methods and classes here
string diff(int[] s_a, int[] s_b, int index){
	if(index == s_b.Count()){
		var subArr = s_a.Where((x, i) => i >= index).Reverse();
		return string.Join(string.Empty, subArr);
	}
	
	//assuming a>=b
	if(s_a[index] >= s_b[index]){
		var temp = (s_a[index] - s_b[index]);//.Dump("1");
		return diff(s_a, s_b, ++index) + temp;
	} else {
		// bug what if s_a[index + 1] is 0
		if(s_a[index + 1] != 0){
			s_a[index + 1] = s_a[index + 1] - 1;
		} else {
			for(int i = index; i < s_a.Count(); i++){
				if(s_a[i + 1] != 0){
					s_a[i + 1] = s_a[i + 1] - 1;
					break;
				} else {
					s_a[i + 1] = 9;
				}
			}
		}
		var temp = ((s_a[index] + 10) - s_b[index]);//.Dump("2");
		return diff(s_a, s_b, ++index) + temp;
	}
}