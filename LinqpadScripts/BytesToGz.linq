<Query Kind="Statements">
  <Namespace>System.IO.Compression</Namespace>
</Query>

string _filesOrigin = @"C:\and\enlistments\Sandbox\PythonScripts\train\";  // got all those bytes files to a separate folder here

string _filesDest = @"C:\and\enlistments\Sandbox\PythonScripts\train_gz\";
Directory.CreateDirectory(_filesDest);
string[] files = Directory.GetFiles(_filesOrigin,"*.bytes");

foreach (String f in files)
{
	string fileToBeCompressed = f;
	string compressedFile = _filesDest + f.Replace(_filesOrigin,"") + ".gz";
	
	using (FileStream target = new FileStream(compressedFile, FileMode.Create, FileAccess.Write))
	using (GZipStream alg = new GZipStream(target, CompressionMode.Compress))
	{
	byte[] data = File.ReadAllBytes(fileToBeCompressed);
	alg.Write(data, 0, data.Length);
	alg.Flush();
	}
}