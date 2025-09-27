public class Solution {
    public bool ContainsDuplicate(int[] nums) {
         int start = 0;
 int end = 1;
 bool res = true;
 Array.Sort(nums);

 while (start < end && end<nums.Length)
 {
     Console.WriteLine("while started");
     if(nums[start] == nums[end])
     {
         Console.WriteLine("duplicate found :" + nums[start]);
         return res;
     }
     else
     {
         Console.WriteLine("start : " + nums[start]);
         Console.WriteLine("end value :" + nums[end]);
         start++;
         end++;
     }
     
   
 }

 return false;
    }
}