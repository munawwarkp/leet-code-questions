public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> res = new List<bool>();
var greatestNo = candies.Max();
for(int i=0; i<candies.Length; i++)
{
    if (candies[i]+extraCandies >= greatestNo)
    {                  
        res.Add(true);
    }
    else
    {
        res.Add(false);
    }
}
return res;
    }
}