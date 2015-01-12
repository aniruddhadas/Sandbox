<Query Kind="Program">
  <NuGetReference>CsvHelper</NuGetReference>
</Query>

void Main()
{
	var headerLine = File.ReadAllLines(@"c:\users\and\downloads\weather.dat").First();
	var positions = GetWordPostions(headerLine);
	var data = File.ReadLines(@"c:\users\and\downloads\weather.dat").Skip(2).Select(x => new {
												Dy = x.Substring(positions[0].Item1,positions[0].Item2).Trim(),
												MxT = double.Parse(x.Substring(positions[1].Item1,positions[1].Item2).Trim(new char[] {' ', '*'})),
												MnT = double.Parse(x.Substring(positions[2].Item1,positions[2].Item2).Trim(new char[] {' ', '*'})),
//												AvT = x.Substring(positions[3].Item1,positions[3].Item2).Trim(),
//												HDDay = x.Substring(positions[4].Item1,positions[4].Item2).Trim(),
//												AvDP = x.Substring(positions[5].Item1,positions[5].Item2).Trim(),
//												OneHrP = x.Substring(positions[6].Item1,positions[6].Item2).Trim(),
//												TPcpn = x.Substring(positions[7].Item1,positions[7].Item2).Trim(),
//												WxType = x.Substring(positions[8].Item1,positions[8].Item2).Trim(),
//												PDir = x.Substring(positions[9].Item1,positions[9].Item2).Trim(),
//												AvSp = x.Substring(positions[10].Item1,positions[10].Item2).Trim(),
//												Dir = x.Substring(positions[11].Item1,positions[11].Item2).Trim(),
//												MxS = x.Substring(positions[12].Item1,positions[12].Item2).Trim(),
//												SkyC = x.Substring(positions[13].Item1,positions[13].Item2).Trim(),
//												MxR = x.Substring(positions[14].Item1,positions[14].Item2).Trim(),
//												// the last columns is misformed so need to do -1
//												MnR = x.Substring(positions[15].Item1,positions[15].Item2 - 1).Trim(),
//												AvSLP = x.Substring(positions[16].Item1,positions[16].Item2).Trim(),
												})
//												.Take(30)
												.Where(x => x.MxT - x.MnT == 2)
//												.Select(x => x.MxT - x.MnT)
//												.Min()
												.Dump();
}

//string PurgeAndGetString(){
//	
//}

// Define other methods and classes here
List<Tuple<int, int>> GetWordPostions(string headerLine){
	List<Tuple<int, int>> startPostions = new List<Tuple<int, int>>();
	
	// compute the 
	int i=0;
	int start=0;
	bool isFirst = true;
	while(i<headerLine.Length - 1){
		
		if(!char.IsWhiteSpace(headerLine[i+1]) &&  char.IsWhiteSpace(headerLine[i])){
			if(isFirst){
				start = 0;
				isFirst = false;
				i++;
				continue;
			}
			
			//create a new tuple and add it to the list
			var positionTuple = new Tuple<int,int>(start + 1, i - start);
			startPostions.Add(positionTuple);
			
			//reset start;
			start = i;	
		}
		i++;
	}
	
	// for the last string
	var positionTuple1 = new Tuple<int,int>(start, headerLine.Length - start);
	startPostions.Add(positionTuple1);
	return startPostions.Dump();
}