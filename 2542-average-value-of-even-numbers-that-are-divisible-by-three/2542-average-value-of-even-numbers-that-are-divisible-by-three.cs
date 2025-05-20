public class Solution {
    public int AverageValue(int[] nums) {
        int filter = (Int32)nums.Where(num => num%2==0).Where(even => even%3==0).DefaultIfEmpty().Average();

        return filter;
    }
}