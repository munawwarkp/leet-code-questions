public class Solution {
    public bool JudgeCircle(string moves) {
         int verticalCount = 0;
 int horizontalCount = 0;

 for(int i = 0; i < moves.Length; i++)
 {
     if (moves[i] == 'U')
         verticalCount++;
     if (moves[i] == 'D')
         verticalCount--;
     if (moves[i] == 'L')
         horizontalCount--;
     if (moves[i] == 'R')
         horizontalCount++;
     
 }
 return horizontalCount == 0 && verticalCount == 0;
    }
}