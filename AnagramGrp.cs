public class Solution
{
	public List<List<string>> GroupAnagrams(string[] strs)
	{
		// create a hash map where each key is the sorted version of a string. And, the value is a list of strings belonging to that anagram group.

		// iterate through each string in the input list -
		
			// sort the characters of the string to form a key

			// append the original string to the list corresponding to this key

		// after processing all strings, return all values from the hash map, which represents the grouped anagrams
	}
}