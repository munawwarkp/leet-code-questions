public class Solution {
//     public int RemoveDuplicates(int[] nums) {
//        int[] newArr = new int[] {};

//  foreach(int i in nums)
//  {
//      if (!newArr.Contains(i))
//      {
//        newArr =  newArr.Concat(new int[] { i }).ToArray();
//      }

//  }
//   for(int i = 0; i < newArr.Length; i++)
//  {
//      nums[i] = newArr[i];
//      Console.WriteLine(i);
//  }
       
//  return newArr.Length;
//     }


 public int RemoveDuplicates(int[] nums)
 {

     int index = 1;

     for(int i = 0; i < nums.Length; i++)
     {
         if (nums[i] != nums[index - 1])
         {
             nums[index] = nums[i];
             index++;
         }
     }

     return index;

 }

}