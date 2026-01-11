public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        
        HashSet<int> hs = new HashSet<int>();
        List<int> li = new List<int>();
        for(int i=0; i<nums.Length; i++){
            if(!hs.Contains(nums[i])){
                hs.Add(nums[i]);
            }else{
                li.Add(nums[i]);
            }
        }

        return li.ToArray();
    }
}