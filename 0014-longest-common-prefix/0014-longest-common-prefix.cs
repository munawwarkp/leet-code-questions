public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
         Console.WriteLine(string.Join(" ",strs));
        int first = 0;
        int last = strs.Length-1;
        StringBuilder sb = new StringBuilder();

        int minLength = strs.Min(s => s.Length);
        for(int i=0; i< minLength; i++)
        {
 
            if(strs[first][i] == strs[last][i])
        {
            sb.Append(strs[first][i]);

        }
        if (strs[first][i] != strs[last][i])
        {
            return sb.ToString();
        }
            
        }
        return sb.ToString();
    }
}