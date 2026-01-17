public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int count = 0; ;

Dictionary<char, int> jewelDic = new Dictionary<char, int>();
foreach(var i in jewels)
{
    jewelDic[i] = 1;
}

foreach(var s in stones)
{
    if (jewelDic.ContainsKey(s))
    {
        count++;
    }
}
return count;
    }
}