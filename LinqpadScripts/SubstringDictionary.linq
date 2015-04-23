<Query Kind="Program" />

void Main()
{
	var words = new string[]{"raw", "warrener"};
	LookupDictionary(words).Dump();
}

// Define other methods and classes here
Dictionary<string, List<string>> LookupDictionary(string[] words){
	Dictionary<string, List<string>> lookupDictionary = new Dictionary<string, List<string>>();
    foreach(var word in words){
        for(int i=1;i<word.Length;i++){
            var subString = reverse(word.Substring(word.Length - i, i));
            if(lookupDictionary.ContainsKey(subString)){
                
                lookupDictionary[subString].Add(word);
            } else {
                lookupDictionary[subString] = new List<string>();
                lookupDictionary[subString].Add(word);
            }
        }
    }
	return lookupDictionary;
}