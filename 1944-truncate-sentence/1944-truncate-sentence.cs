public class Solution {
    public string TruncateSentence(string s, int k) {
        string[] sArr = s.Split(' ').Take(k).ToArray();
        string sReturn = string.Join(' ', sArr);
        return sReturn;
    }
}