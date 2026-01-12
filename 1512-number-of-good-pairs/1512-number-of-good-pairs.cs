public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int count = 0;

 for (int i = 0; i < nums.Length; i++)
 {
     int j = i+1;

     while (i < j && j<nums.Length)
     {
         if (nums[i] == nums[j] && i != j)
         {
            count++;
         }
         j++;
     }
 }
 return count;
    }
}