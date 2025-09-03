public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
          var sortedArray = nums.Select((val, index) => new { Value = val, Index = index }).OrderBy(x => x.Value).ToArray();
  int[] resArr = new int[2];

  int left = 0;
  int right = sortedArray.Length - 1;

  while (left < right)
  {
      int sum = sortedArray[left].Value + sortedArray[right].Value;

      if(sum == target)
      {
          resArr[0] = sortedArray[left].Index;
          resArr[1] = sortedArray[right].Index;
          return resArr;
      }
      else if(sum < target)
      {
          left++;
      }
      else
      {
          right--;
      }
  }
  return Array.Empty<int>();


    }
}