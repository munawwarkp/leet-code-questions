public class Solution {
    public int[] MinOperations(string boxes) {
        
int[] num = new int[boxes.Length];
int i = 0;

while (i < boxes.Length)
{
    int j = 0;
    int distance = 0;

    while (j < boxes.Length )
    {
        if (boxes[j] == '1' && i!=j)
        {
            distance += Math.Abs(i - j);
            num[i] = distance;
        }
        j++;

    }
    i++;
}

return num;
    }
}