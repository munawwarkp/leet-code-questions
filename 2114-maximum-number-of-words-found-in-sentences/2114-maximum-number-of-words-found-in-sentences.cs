public class Solution {
    public int MostWordsFound(string[] sentences) {
        string str = "";
int maxWords = 1;

for (int i = 0; i < sentences.Length; i++)
{
    str = sentences[i];
    int j = 0;
    int minWords = 1;

    while (j < str.Length)
    {
        if (str[j] == ' ')
        {
            minWords++;
        }
        j++;
    }

    if(minWords > maxWords)
    {
        maxWords = minWords;
    }
}
return maxWords;
    }
}