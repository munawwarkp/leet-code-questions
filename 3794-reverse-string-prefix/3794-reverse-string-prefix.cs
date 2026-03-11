public class Solution {
    public string ReversePrefix(string s, int k) {
        string revK = "";

int i = k;

while(k-1 >= 0)
{
    revK += s[k-1];
    k--;
}
while(i < s.Length)
{
    revK += s[i];
    i++;
}
return revK;
    }
}