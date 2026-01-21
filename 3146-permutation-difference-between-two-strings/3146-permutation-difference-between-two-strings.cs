public class Solution {
    public int FindPermutationDifference(string s, string t) {
         int sum = 0;

 Dictionary<char, int> sDic = new Dictionary<char, int>();   
 Dictionary<char, int> tDic = new Dictionary<char, int>();
 
 for(int i=0; i<s.Length; i++)
 {
     sDic[s[i]] = i;
 }

 for(int j = 0; j < t.Length; j++)
 {
     if(sDic.ContainsKey(t[j]))
     {
         int absDiff = int.Abs(sDic[t[j]] - j);
         sum += absDiff;
     }
 }
 return sum;
    }
}