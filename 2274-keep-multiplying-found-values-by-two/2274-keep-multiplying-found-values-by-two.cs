public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        int i = 0;
do
{
    if (nums[i] == original)
    {
        original = nums[i] * 2;
        i=-1;
        Console.WriteLine(original);
    }
      i++;

}
while (i < nums.Length);
return original;
    }
}