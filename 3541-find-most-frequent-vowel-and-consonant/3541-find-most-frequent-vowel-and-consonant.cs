public class Solution {
    public int MaxFreqSum(string s) {
         char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
          Dictionary<char, int> dic = new Dictionary<char, int>();

 Dictionary<char, int> dicVowel = new Dictionary<char, int>();
 Dictionary<char, int> notVowel = new Dictionary<char, int>();

 bool checkVowel(char c)
 {
     bool res = false;
     foreach (var i in vowels)
     {
         if (c == i)
         {
             res = true;
             return res;
         }
     }

     return res;
 }


 foreach (var ch in s)
 {
     if (!dic.ContainsKey(ch))
     {
         dic[ch] = 1;
     }
     else
     {
         dic[ch] += 1;
     }
 }

 foreach (var k in dic)
 {
     if (checkVowel(k.Key))
     {
         dicVowel[k.Key] = k.Value;
     }
     else
     {
         notVowel[k.Key] = k.Value;
     }
 }

 int vowelMax = dicVowel.Any() ? dicVowel.Max(d => d.Value) : 0;
int notVowelMax = notVowel.Any() ? notVowel.Max(nv => nv.Value) : 0;
return vowelMax + notVowelMax;
 
    }
}