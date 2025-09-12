public class Solution {
    // public double FindMaxAverage(int[] nums, int k) {
    // double maxAverage = 0;
    // int lastSum = int.MinValue;
    // int sum = 0;


    //     for (int i = 0; i<= nums.Length-k; i++)
    //     {
    //         sum = 0;
    //         for (int j = i; j < k+i; j++)
    //         {
    //             sum += nums[j];
                
    //         }
    //         if(sum > lastSum)
    //             lastSum = sum;

    //     }
    // maxAverage = Convert.ToDouble(lastSum)/k;
    // return maxAverage;
    // }


    //using sliding window
     public double FindMaxAverage(int[] nums, int k)
 {
     int sum = 0;

     for(int i=0; i<k; i++)
     {
         sum += nums[i];
     }

     int maxSum = sum;

     for(int i=k; i<nums.Length; i++)
     {
         sum += nums[i] - nums[i-k];
         if(sum > maxSum)
             maxSum = sum;

     }
     return (double)maxSum/k;

 }
}

