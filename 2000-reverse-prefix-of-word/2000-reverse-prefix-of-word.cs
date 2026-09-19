public class Solution {
    public string ReversePrefix(string word, char ch) {
        bool isFound = false;

string result = ""; 
for (int i=0; i< word.Length; i++)
{
    if (word[i] == ch && !isFound)
    {
        isFound = true;
        int j = i;
        while(j >= 0)
        {
            result += word[j];
            j--;
        }
        continue;
    }

    if (isFound)
    {
        result += word[i];
    }

     if( i == word.Length - 1 && !isFound)
 {
     result = word;
 };
}
return result;
    }
}