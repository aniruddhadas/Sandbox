<Query Kind="Program" />

void Main()
{
//	PossibleCurrencyPermutations(100, new [] {1, 5, 10, 25});
	PossibleCurrencyPermutations(100, new [] {5, 1, 10, 25});
}

// Define other methods and classes here
void PossibleCurrencyPermutations(int value, int[] possibleDenominations) {
	RecursivePossibleCurrencyPermutations(value, 0, 0, possibleDenominations, string.Empty);
}

void RecursivePossibleCurrencyPermutations(int targetValue, int currentValue, int currentIndex, int[] possibleDenominations, string currentDenoms){
	if(currentValue == targetValue){
		currentDenoms.Dump();
		return;
	}
	
	for(var i = currentIndex; i < possibleDenominations.Length; i++){
		var denom = possibleDenominations[i];
		var possibleUsageCounts = Enumerable.Range(1, targetValue/denom + 1);
		foreach(var j in possibleUsageCounts){
			if((currentValue + j*denom) <= targetValue){
				RecursivePossibleCurrencyPermutations(targetValue, (currentValue + j*denom), i + 1, possibleDenominations, currentDenoms + " " + denom + "->" + j);
			}
		}
	}
}