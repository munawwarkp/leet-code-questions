public class Solution {
    public int ScoreOfString(string s) {
        int j = 0;
        int sum = 0;

for(int i=0; i<s.Length && j<s.Length-1; i++)
{
    j = i + 1;
    sum += Math.Abs( ( Convert.ToInt32( s[i]) - Convert.ToInt32(s[j])));
}
    return sum;
    }

}