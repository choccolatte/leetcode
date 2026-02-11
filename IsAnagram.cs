public class Solution
{
	public bool IsAnagram(string s, string t)
	{
		// comparing str length first
		if(s.Length != t.Length)
		{
			return false;
		}

		// seperating string into char, storing them into char[]
		char[] sSrt = s.ToCharArray();
		char[] tSrt = t.ToCharArray();

		// sorting the char[]
		Array.Sort(sSrt);
		Array.Sort(tSrt);

		// comparing one array to another
		return sSrt.SequenceEqual(tSrt);
	}
}