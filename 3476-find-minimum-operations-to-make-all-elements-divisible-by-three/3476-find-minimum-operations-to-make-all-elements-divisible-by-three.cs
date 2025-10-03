public class Solution {
    public int MinimumOperations(int[] nums) {
          int count = 0;
 for(int i=0; i<nums.Length; i++)
  {
      if (nums[i] % 3 == 1)
      {
          nums[i] -= 1;
          count++;
      }
      if (nums[i]%3 == 2)
      {
          nums[i] += 1;
          count++;
      }
  }
  return count;

    }
}