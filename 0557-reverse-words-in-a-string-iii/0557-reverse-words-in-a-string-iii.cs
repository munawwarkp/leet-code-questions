public class Solution
{
    public string ReverseWords(string s)
    {
        string[] sArr = s.Split(' ');
       var res = sArr.Select(s => s.ToCharArray().Reverse().ToArray());
        StringBuilder sb = new StringBuilder();

        foreach(var c in res)
        {
            sb.Append(c);
            sb.Append(' ');
        }
        return sb.ToString().Trim() ;
    }
}