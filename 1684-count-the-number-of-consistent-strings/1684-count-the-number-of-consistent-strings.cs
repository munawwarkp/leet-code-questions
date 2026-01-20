public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
         int count = 0;

 Dictionary<char, int> allowedDic = new Dictionary<char, int>();

 for(int k=0; k<allowed.Length; k++)
 {
     allowedDic[allowed[k]] = k;
 }

 int j;

 for (int i=0; i<words.Length; i++)
 {
     bool res = true;
     for ( j=0; j < words[i].Length; j++)
     {
         if (!allowedDic.ContainsKey(words[i][j]))
         {
             res = false;
             break;
         }

     }

     if (res)
         count++;
 }
 return count;
    }
}