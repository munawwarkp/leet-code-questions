public class Solution {
    public int ReverseDegree(string s) {
        

int sum = 0;
int zAsciVal = Convert.ToInt32('z');

for (int i = 0; i<s.Length; i++)
{
    sum += ((zAsciVal+1) - Convert.ToInt32(s[i])) * (i+1);
}
return sum;
    }
// Dictionary<char, int> charIndex = new Dictionary<char, int>();
// int aAsciVal = Convert.ToInt32('a');
// int zAsciVal = Convert.ToInt32('z');
// int position = 26;

// while (aAsciVal <= zAsciVal)
// {
//     charIndex[Convert.ToChar(aAsciVal)] = position;
//     position--;
//     aAsciVal++;
// }

// int sum = 0;    

// for (int i=0; i< s.Length; i++)
// {
//     charIndex.TryGetValue(s[i], out int index);
//     sum += index * (i + 1);
// }
// return sum;
//     }
}