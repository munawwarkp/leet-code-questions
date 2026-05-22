public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
         for(int i=0; i<k; i++)
 {
     int min = nums.Min();
     int minIndex = Array.IndexOf(nums, min);

     int insteadMin = min * multiplier;
     nums[minIndex] = insteadMin;

 }
 return nums;
    }
}