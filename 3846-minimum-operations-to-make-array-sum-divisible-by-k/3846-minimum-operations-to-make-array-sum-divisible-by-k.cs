public class Solution {
    public int MinOperations(int[] nums, int k) {
        int sum = nums.Sum();
        if (sum % k == 0)
        {
            return 0;
        }
        if(sum < k)
        {
            return sum;
        }
        return sum%k;
    }
}