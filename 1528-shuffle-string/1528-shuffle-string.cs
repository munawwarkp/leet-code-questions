public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] resultArr = new char[s.Length];
string result = "";

for (int i=0; i<s.Length; i++)
{
    resultArr[indices[i]] = s[i];
        
}
for(int j = 0; j < resultArr.Length; j++)
{
    result += resultArr[j];
}
return result;
    }
}