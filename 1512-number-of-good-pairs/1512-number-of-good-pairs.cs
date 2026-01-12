public class Solution {
    public int NumIdenticalPairs(int[] nums) {
       Dictionary<int, int> dc = new Dictionary<int, int>();

 int count = 0;

 for(int i=0; i<nums.Length; i++)
 {
     if (!dc.ContainsKey(nums[i]))
     {
         dc[nums[i]] = 1;
     }
     else
     {
         count += dc[nums[i]];
         dc[nums[i]] += 1;
     }
 }
 return count;
    }
}