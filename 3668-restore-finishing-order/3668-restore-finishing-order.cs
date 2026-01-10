public class Solution {
    public int[] RecoverOrder(int[] order, int[] friends) {
        
        List<int> res = new List<int>();
        HashSet<int> values = new HashSet<int>();

        foreach (var f in friends)
        {
            values.Add(f);
        }

        for (int i = 0; i < order.Length; i++)
        {
            if (values.Contains(order[i]))
            {
                res.Add(order[i]);
            }
        }

        return res.ToArray();
    }
}