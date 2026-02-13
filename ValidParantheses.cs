class Solution
{
	public bool IsValid(string str)
	{
		// while string still contains (), {}, []
		while(str.Contains("()") || str.Contains("{}") || str.Contains("[]"))
		// remove all occurances of those pairs
		{
			str = str.Replace("()", "");
			str = str.Replace("{}", "");
			str = str.Replace("[]", "");
		}

		// after no pairs can be removed
			// if string is empty, return true
			// otherwise return false
		return str == "";
	}
}