public class Solution {
    public int PrefixCount(string[] words, string pref) {
       int prefLength = pref.Length;
int res = 0;

for (int i = 0; i < words.Length; i++)
{
    string newString = "";

    for (int j = 0; j< words[i].Length && j< prefLength; j++)
    {
        newString += words[i][j];
    }
    if(newString == pref)
    {
        res++;
    }
}
return res; 
    }
}