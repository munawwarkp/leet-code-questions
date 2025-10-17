public class Solution {
    public int Search(int[] nums, int target) {
          Array.Sort(nums);
  int left = 0;
  int right = nums.Length - 1;

  while(left <= right)
  {
      int mid = (left + right) / 2;
      if (target == nums[mid])
      {              
          return mid;
      }            
      if (target < nums[mid])
      {                   
          right = mid - 1;
      }
      if(target > nums[mid])
      {
          left = mid + 1;
          
      }
  }
  return -1;
    }
}