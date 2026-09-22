public class Solution {
    public string DecodeMessage(string key, string message) {
        string result = "";

Dictionary<char, char> dict = new Dictionary<char, char>();
char value = 'a';

for (int i =0; i<key.Length; i++)
{
    if(value > 'z')
    {
        break;
    }

    if(key[i] == ' ')
    {
        continue;
    }

    if (!dict.ContainsKey(key[i]))
    {
        dict.Add(key[i], value);
        value++;

    }

}

for(int j =0; j<message.Length; j++)
{
    if (message[j] == ' ')
    {
        result += " ";
        continue;
    }
    if (dict.ContainsKey(message[j]))
    {
        result += (dict[message[j]]);
    }


}

return result;
    }
}