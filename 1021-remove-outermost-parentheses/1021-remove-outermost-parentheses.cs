public class Solution {
    public string RemoveOuterParentheses(string s) {
        int x = 0;
string result = "";

for (int i=0; i<s.Length; i++)
{
    if (s[i] == '(')
    {
        x ++;
        if(x > 1)
        {
            result += "(";
        }
    }
    else
    {
        x--;
        if(x >= 1)
        {
            result += ")";
        }
    }

}
return result;
    }
}