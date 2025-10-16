public class Solution {
    public int AlternatingSum(int[] nums) {
         int sum = 0;
 for(int i=0;i<nums.Length; i++)
 {
     if (i % 2 == 0)
     {
         sum += nums[i];
     }
     else
     {
         sum-= nums[i];
     }
 }
 return sum;
    }
}