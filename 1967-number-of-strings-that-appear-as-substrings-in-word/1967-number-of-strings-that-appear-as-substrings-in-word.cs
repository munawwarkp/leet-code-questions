public class Solution {
    public int NumOfStrings(string[] patterns, string word) {

int count = 0;

Dictionary<string, int> dict = new Dictionary<string, int>();

for (int i = 0; i < word.Length; i++)
{
   for(int j = i+1; j <= word.Length; j++)
    {
        string sub = word.Substring(i, j - i);
        dict[sub] = 1;
    }

}

for(int k=0; k < patterns.Length; k++)
{
    if (dict.ContainsKey(patterns[k]))
    {
        count++;
    }
}

return count;
    }
}