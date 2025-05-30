public class Solution {
    public int DifferenceOfSum(int[] nums) {
       var sumOfElem = nums.Aggregate(0, (accum, elem) => accum + elem);
        var elemToString = nums.Select(x => string.Join("",nums));
        var a = elemToString.Distinct();
        string z = "";
        foreach(var elem in a)
        {
            z = elem;
        }
        Console.WriteLine(z);

        var sumOfDig =z.Aggregate(0,(acc, elem) => acc + (elem - '0'));
        return Math.Abs(sumOfDig - sumOfElem); 
    }
}