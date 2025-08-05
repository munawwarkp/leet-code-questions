public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
      
                int[] mergedArray = nums1.Concat(nums2).ToArray();
                Array.Sort(mergedArray);
                int mergedArrayLength = mergedArray.Length;
                if (mergedArrayLength % 2 == 0)
                {
                    return Convert.ToDouble((mergedArray[mergedArrayLength / 2] + mergedArray[(mergedArrayLength / 2) - 1]))/2;
                    
                }
                else
                {
                    return Convert.ToDouble (mergedArray[mergedArrayLength / 2]);
                }
    }
}