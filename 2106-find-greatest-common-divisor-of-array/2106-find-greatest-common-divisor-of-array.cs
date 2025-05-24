public class Solution {
    public int FindGCD(int[] nums) {
      
      int max = nums.Max();
      int min = nums.Min();
      int res = 1;

        for(int i=1;i<=min;i++){
            if(min%i==0 && max%i==0){
                res = i;
            }
        }
        return res;
    }
    
}