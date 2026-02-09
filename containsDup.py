# given an int array nums, return true ifany value appears more than once in the array, otherwise return false

class Solution:
	def hasDuplicate(self, nums: List[int]) -> bool:
		for i in range(len(nums)):
			for j in range(i + 1, len(nums)):
				if nums[i] == nums[j]:
					return True
		return False

# using sorting
class Solution2:
	def hasDup(self, nums: List[int]) -> bool:
		nums.sort()
		for i in range(1, len(nums)):
			if nums[i] == nums[i-1]:
				return True
		return False

#in C#
# public class Solution{
# 	public bool hasDup(int[] nums){
# 		for(int i = 0; i < nums.Length; i++){
# 			for(int j = i + 1; j < nums.Length; j++){
# 				if(nums[i] == nums[j]){
# 					return true;
# 				}
# 			}
# 		}

# 		return false;
# 	}
# }