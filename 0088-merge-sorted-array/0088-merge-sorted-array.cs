public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        for(int i=0; i<nums1.Length; i++)
{
    if(i >= m)
    {
        nums1[i] = nums2[i-m];
    }
   
}

Array.Sort(nums1);
    }
}