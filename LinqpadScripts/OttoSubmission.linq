<Query Kind="Statements" />

var data = File
			.ReadAllLines(@"C:\and\enlistments\Sandbox\Kaggle\OttoGroupProductClassificationChallenge\test3.csv\.inst.txt")
			.Skip(1)
			.Select(x => {
							var parts = x.Split('\t');
							var id = parts[0];
							var dict = new Dictionary<string, double>();
							for(int i=1;i<parts.Length;i=i+2){
								dict.Add(parts[i], double.Parse(parts[i+1]));
							}
							
							return id + "," + string.Join(",", dict.OrderBy(y => y.Key).Select(z => z.Value));
						})
			.Dump();
File
.WriteAllText(@"C:\and\enlistments\Sandbox\Kaggle\OttoGroupProductClassificationChallenge\test3.csv\.inst1.txt", "id,Class_1,Class_2,Class_3,Class_4,Class_5,Class_6,Class_7,Class_8,Class_9\r\n");
File
.AppendAllLines(@"C:\and\enlistments\Sandbox\Kaggle\OttoGroupProductClassificationChallenge\test3.csv\.inst1.txt", data);