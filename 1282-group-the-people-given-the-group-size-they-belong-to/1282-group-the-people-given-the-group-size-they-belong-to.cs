public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        Dictionary<int , List<int>> tempDic = new Dictionary<int, List<int>>();
 List<List<int>> res = new List<List<int>>();

 for(int i=0; i<groupSizes.Length; i++)
 {
     int size = groupSizes[i];
     if(!tempDic.ContainsKey(size))
     {
         tempDic[size] = new List<int>();
     }

     tempDic[size].Add(i);

     if (tempDic[size].Count == size)
     {
         res.Add(new List<int>(tempDic[size]));
         tempDic[size].Clear();
     }
 }
 return res.ToArray(); 
    }
}