public class Solution {
    public int ReverseDegree(string s) {
        
Dictionary<char, int> charIndex = new Dictionary<char, int>();
int aAsciVal = Convert.ToInt32('a');
int zAsciVal = Convert.ToInt32('z');
int position = 26;

while (aAsciVal <= zAsciVal)
{
    charIndex[Convert.ToChar(aAsciVal)] = position;
    position--;
    aAsciVal++;
}

int sum = 0;    

for (int i=0; i< s.Length; i++)
{
    charIndex.TryGetValue(s[i], out int index);
    sum += index * (i + 1);
}
return sum;
    }
}