public class Solution {
    public void MoveZeroes(int[] nums) {
        int left = 0;
int right = 0;

while (right < nums.Length)
{

    //Console.WriteLine("ind right :" + right);
    if (nums[right] != 0)
    {
        (nums[left], nums[right]) = (nums[right], nums[left]);

        //Console.WriteLine("ind left : " + left);
        //Console.WriteLine(nums[left]);
        //Console.WriteLine(nums[right]);
        left++;

    }
    right++;

}
    }
}