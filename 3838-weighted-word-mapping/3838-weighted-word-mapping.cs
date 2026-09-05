public class Solution {
    public string MapWordWeights(string[] words, int[] weights) {
        string result = "";

Dictionary<char, int> charWeights = new Dictionary<char, int>();

for(int i = 0; i < weights.Length; i++)
{
    charWeights.Add((char)('a' + i), weights[i]);
};

for (int i = 0; i<words.Length; i++)
{
    int wordLength = words[i].Length;
    int sum = 0;
    int resultModulo = 0;

    for (int j = 0; j<weights.Length; j++)
    {
        if (j >= wordLength)
        {
            break;
        }
        sum+= charWeights[words[i][j]];
    }

    resultModulo = sum % 26;

    result += (char)('z' - resultModulo);
}
return result;
    }
}