public class Solution {
    public int MaxDistinct(string s) {
        
        Hashtable ht = new Hashtable();
        int count = 0;

        for(int i=0; i<s.Length; i++){
            if(!ht.ContainsKey(s[i])){
                ht[s[i]] = count++;
            }
        }

        return count;
    }
}