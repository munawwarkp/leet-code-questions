public class Solution {
    public IList<int> StableMountains(int[] height, int threshold) {
      List<int > stable = new List<int>();
        for(int i=1; i< height.Length; i++)
        {
            Console.WriteLine("index : "+i);
            if (height[i-1] > threshold)
            {
                
                stable.Add(i);
            }
        }
        return stable;
    }
}