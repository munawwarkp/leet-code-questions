public class Solution {
    public bool CheckIfPangram(string sentence) {
        
Dictionary<char, int> dict = new Dictionary<char, int>();
for (int i = 0; i < sentence.Length; i++)
{
    if(dict.ContainsKey(sentence[i]))
 {
     continue;
 };
    dict.Add(sentence[i], sentence[i] - 0);
} 

return dict.Count == 26;
    }
}