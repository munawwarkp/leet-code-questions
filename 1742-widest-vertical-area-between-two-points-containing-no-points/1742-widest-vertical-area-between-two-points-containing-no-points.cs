public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        
          int[]newArr = new int[points.Length];

  for (int i = 0; i < points.Length; i++)
  {
      for (int j=0; j < points[i].Length; j++)
      {
          if(j == 0)
          {
              newArr[i] = points[i][j];
          }
      }
  }
  Array.Sort(newArr);

  int l = 1;
  int greatest = 0;
  for(int i=0;i < newArr.Length-1; i++)
  {
      if (newArr[l] - newArr[i] > greatest)
      {

          greatest = newArr[l] - newArr[i];
         
      }
     
      l++;
  }

  return greatest;
    }
}