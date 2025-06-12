public class Solution {
    public int BuyChoco(int[] prices, int money) {
       List<int> min_price = new List<int> {};
for(int i = 0; i < prices.Length; i++)
{
    for(int j = i + 1; j < prices.Length; j++)
    {
        min_price.Add(prices[i] + prices[j]);
    }
}

int minprice = min_price.Min();
Console.WriteLine(minprice);

if(minprice > money)
{
    return money;
}
else
{
    return money-minprice;
}
    }
}