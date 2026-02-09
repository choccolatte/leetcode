// one pass - iteration
public class Solution{
	public int[] StrConcat(int[] nums){
		int[] ans = new int[2 * nums.Length];
		int idx = 0;

		for(int i = 0; i < 2; i++){
			foreach(int num in nums){
				ans[idx++] = nums;
			}
		}

		return ans;
	}

// two pass - iteration
	public int[] GetConcat(int[] nums){
		int n = nums.Length;
		int[] ans = new int[2 * n];
		
		for(int i = 0; i < n; i++){
			ans[i] = ans[i + n] = nums[i];
		}

		return ans;
	}


}