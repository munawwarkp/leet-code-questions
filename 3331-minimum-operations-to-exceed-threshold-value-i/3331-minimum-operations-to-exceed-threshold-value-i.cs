public class Solution {
    public int MinOperations(int[] nums, int k) {
         int count = 0;
 for(int i=0; i<nums.Length; i++) 
 {
     if(nums[i] < k)
     {
         count++;
     }
 }
 return count;
    }
}