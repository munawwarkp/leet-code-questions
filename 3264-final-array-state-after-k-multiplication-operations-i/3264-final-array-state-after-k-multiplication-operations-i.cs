public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
         var pq = new PriorityQueue<(int value, int index),(int value, int index)>();

for(int i=0; i< nums.Length; i++)
 {
     pq.Enqueue((nums[i], i), (nums[i], i));
 };

 for (int i=0; i<k; i++)
 {
     var current = pq.Dequeue();

     int newValue = current.value * multiplier;
     nums[current.index] = newValue;

     pq.Enqueue((newValue, current.index), (newValue, current.index));
 }

 return nums;
    }
}