public class Solution {
    public int MaxDistinct(string s) {
        
       HashSet<char> hs = new HashSet<char>();
       for(int i=0; i<s.Length; i++){
            hs.Add(s[i]);
       }

       return hs.Count;
    }
}