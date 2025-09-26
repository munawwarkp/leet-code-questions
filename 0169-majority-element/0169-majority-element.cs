public class Solution {
    public int MajorityElement(int[] nums) {
         int length = nums.Length;
 int forMajorityElem = length / 2;
 int count = 1;
 int majorityElem = 0;

 int left = 0;
 int right = 1;
 Array.Sort(nums);
 if(nums.Length==1){
    return nums[0];
 }
 while(left < right && right <= length-1)
 {
     if (nums[left] != nums[right])
     {
         right++;
         left++;
     }
     else
     {
         count++;
         majorityElem = nums[left];
         right++;
     } 
 }
 return majorityElem;    

    }
}