public class Solution {
    public int DifferenceOfSums(int n, int m) {
        
            List<int> num1 = new List<int>();
            List<int> num2 = new List<int>();
            for(int i=1; i<=n; i++)
            {
                if (i % m == 0)
                {
                    num2.Add(i);
                }
                else
                {
                    num1.Add(i);
                }
            }
          
            Console.WriteLine(num1.Sum());
            return num1.Sum() - num2.Sum();
    }
}