<Query Kind="Program">
  <Connection>
    <ID>54baa410-f69c-47bc-b218-552e09c4b724</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://localhost:8082/OinkCorpAnalytics.svc</Server>
  </Connection>
</Query>

void Main()
{
	var inputString = "I wish you a merry christmas";
	var inputStringBuilder = new StringBuilder(inputString);
	ReverseString(inputStringBuilder);
	inputStringBuilder.Dump();
}

// Define other methods and classes here
void ReverseString(StringBuilder inputString){
	
	int counter = 0;
	int startCounter = 0;
	int endCounter = 0;
	while(counter <= inputString.Length){
		
		if(counter == inputString.Length || inputString[counter] == ' '){
			endCounter = counter - 1;
			ReverseWordInPlace(inputString, startCounter, endCounter);
			startCounter = counter + 1;
		}
		
		counter++;
	}
	
	ReverseWordInPlace(inputString, 0, inputString.Length - 1);
}

void ReverseWordInPlace(StringBuilder s, int startCounter, int endCounter){
	int counter=0;
	startCounter.Dump();
	endCounter.Dump();
	while((startCounter + counter) <= (endCounter + startCounter)/2){
		var temp = s[startCounter + counter];
		s[startCounter + counter] = s[endCounter - counter];
		s[endCounter - counter] = temp;
		counter++;
	}
	s.Dump();
}