public class Solution {
    public int[] DecompressRLElist(int[] nums) {
         int last = nums.Length;
 int i = 0;
 List<int> list = new List<int>();
 while (i < last/2)
 {
     int freq = nums[2 * i];
     int val = nums[2 * i + 1];

     for (int j = 0; j < freq; j++)
     {
         list.Add(val);
     }

     i++;
     
 }
 return list.ToArray();
    }
}