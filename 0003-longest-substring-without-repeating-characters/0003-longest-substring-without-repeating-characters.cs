public class Solution {
    public int LengthOfLongestSubstring(string s) {
          int n = s.Length;
  HashSet<char> chars = new HashSet<char>();
  int maxLength = 0;
  int left = 0;

  for(int i=left; i<n; i++)
  {
      while(chars.Contains(s[i])){
          chars.Remove(s[left]);
          left++;
      }
      chars.Add(s[i]);
      maxLength = Math.Max(maxLength, i - left + 1);
  }
  return maxLength;
    }
}