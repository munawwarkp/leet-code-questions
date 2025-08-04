public class Solution {
    public int RemoveElement(int[] nums, int val) {
          int j = 0;

  for (int i=0;i<nums.Length; i++)
  {
      if(nums[i] != val)
      {
          (nums[i], nums[j]) = (nums[j], nums[i]);
          j++;
      }
      Console.WriteLine(string.Join(" ",nums));
  }
  return j;
    }
}