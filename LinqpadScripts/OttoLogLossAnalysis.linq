<Query Kind="Statements" />

var files = Directory.EnumerateFiles(@"C:\and\enlistments\Sandbox\Kaggle\OttoGroupProductClassificationChallenge\train1.csv", "*.out.txt");//.Dump();
var loglosslist = new List<string>();
foreach(var file in files){
	File.ReadAllLines(file).Where(x => x.Contains("LOG-LOSS:")).Dump(file);
}