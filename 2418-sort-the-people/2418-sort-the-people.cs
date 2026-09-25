public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
List<string> res = new List<string>();  

Dictionary<int, string> dict = new Dictionary<int, string>();
for (int i= 0; i<names.Length; i++)
{
    dict.Add(heights[i], names[i]);
}

foreach (var item in dict.OrderByDescending(x => x.Key))
{
    res.Add(item.Value);
}

return res.ToArray();
    }
}