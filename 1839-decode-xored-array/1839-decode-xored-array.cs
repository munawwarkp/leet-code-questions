public class Solution {
    public int[] Decode(int[] encoded, int first) {
        List<int> decode = new List<int>();
int b = 0;
for (int i=0; i < encoded.Length; i++)
{
    int c = encoded[i];
    if(i == 0)
    {
        decode.Add(first);
        b = first ^ c;
        decode.Add(b);
    }
    else
    {
        Console.WriteLine("b val : " +b);
        b = b ^ c;
        decode.Add(b);
    }



}
return decode.ToArray();
    }
}