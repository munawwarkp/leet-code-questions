public class Solution {
    public int MaxArea(int[] height) {
         int left = 0; 
 int right = height.Length - 1;
 int area = 0;

 Console.WriteLine("area : " + area);
 while(left < right)
 {
     var currentArea = Math.Min(height[left], height[right]) * (right - left);
     area = Math.Max(area, currentArea);

     if (height[left] < height[right])
     {
          left++;

     }
     else
     {
         right--;
     }


 }
 Console.WriteLine("res : " +area);
 return area;
    }
}