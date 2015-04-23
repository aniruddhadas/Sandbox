<Query Kind="Statements" />

var data = File
.ReadLines(@"C:\and\enlistments\Sandbox\Kaggle\OttoGroupProductClassificationChallenge\test.csv\test.csv")
.Skip(1);
data.Take(2).Dump();
var parseddata = data
.Select(x => 
	new {
		Id = x.Split(',')[0],
		BagOfWords = string.Join(" ",x.Split(',').Skip(1).Take(93).Select((y,i) => i+":"+y)),
	})
	.Dump();


	
File
.WriteAllLines(@"C:\and\enlistments\Sandbox\Kaggle\OttoGroupProductClassificationChallenge\test.csv\testdata.csv",
parseddata.Select(x => x.Id + "," + x.BagOfWords));

//1=1,2=2,3=3,4=4,5=5,6=6,7=7,8=8,9=9