public class Solution {
    public string ReversePrefix(string s, int k) {
        string revBeforeK = "";
string afterK = "";
int i = k;

while(k-1 >= 0 || i < s.Length)
{
    if (k != 0)
    {
        revBeforeK += s[k - 1];
        k--;
    }
    if (i != s.Length)
    {
        afterK += s[i];
        i++;       
    }
}
return revBeforeK + afterK;
    }
}