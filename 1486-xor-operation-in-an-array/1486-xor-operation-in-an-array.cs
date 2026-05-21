public class Solution {
    public int XorOperation(int n, int start) {
        int[]nums = new int[n];
int bitWiseXor = 0;

for(int i=0; i<n; i++)
{
    nums[i] = start + 2 * i;
    bitWiseXor ^= nums[i];
}
return bitWiseXor;
    }
}