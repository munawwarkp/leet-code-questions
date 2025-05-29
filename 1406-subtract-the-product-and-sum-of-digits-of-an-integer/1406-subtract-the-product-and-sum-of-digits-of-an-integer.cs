public class Solution {
    public int SubtractProductAndSum(int n) {
        var nArr = n.ToString();
        var mult = nArr.Aggregate(1,(acc, item) => acc * int.Parse(item.ToString()));
        var sum = nArr.Aggregate(0, (acc, item) => acc + (item - '0'));
        
    return mult-sum;
    }
}