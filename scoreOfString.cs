// getting the score of the sum of all adjacent characters in a given string
// algo
// 1. initialize a variable res to store the running total
// 2. iterate through teh string from index 0 to n-2
// 	2.1 for each position i, compute the absolute difference between teh ASCII values of s[i] and s[i+1]
// 	2.2 add this difference to res variable
// 3. return res as the final answer

// class Solution:
// 	def scoreOfString(self, s:str) -> int:
// 		res = 0
// 		for i in range(len(s) - 1):
// 			res += abs(ord(s[i]) - ord(s[i + 1]))
// 		return res

public class Solution{
	static int ScoreOfString(string item){
		int res = 0;
		for(int i = 0; i < item.Length - 1; i++){
			res += Math.Abs(item[i] - item[i + 1]);
		}
		return res;
	}

	static void Main()
	{
		int addedItemValue = ScoreOfString("alphabet");
		Console.WriteLine(addedItemValue);
	}
}