<Query Kind="Program">
  <Namespace>System.Security.Cryptography</Namespace>
</Query>

void Main()
{
	var dictStrings = File.ReadLines(@"C:\Users\and\Downloads\wordlist.txt")
//						.Take(10)
						.Select(x => CalculateMD5Hash(x))
//						.Dump()
						;
	
	var lookupString = "AAAAAAAAAAAAAAAAAAAAAAAAASAAAAAAAASDDXSXXXXXXXX";
	dictStrings.Contains(CalculateMD5Hash(lookupString).Dump()).Dump();
}

// Define other methods and classes here
public int CalculateMD5Hash(string input)
//public string CalculateMD5Hash(string input)
{
    // step 1, calculate MD5 hash from input
    MD5 md5 = System.Security.Cryptography.MD5.Create();
    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
    byte[] hash = md5.ComputeHash(inputBytes);

	// step 2, convert byte array to hex string
//    StringBuilder sb = new StringBuilder();
	byte[] returnVal = new byte[hash.Length];
    for (int i = 0; i < hash.Length; i++)
    {
		bool resultByteHash = true;
		resultByteHash = resultByteHash & GetBit(hash[i], 0);
		resultByteHash = resultByteHash & GetBit(hash[i], 1);
		resultByteHash = resultByteHash & GetBit(hash[i], 2);
		resultByteHash = resultByteHash & GetBit(hash[i], 3);
		returnVal[i] = resultByteHash ? (byte) 1 : (byte) 0;
//        sb.Append(hash[i].ToString("X2"));
//        sb.Append(hash[i].ToString("x2"));
    }
//    return sb.ToString();
    return BitConverter.ToInt32(returnVal, 0);
}

public static bool GetBit(byte b, int bitNumber) {
   return (b & (1 << bitNumber)) != 0;
}