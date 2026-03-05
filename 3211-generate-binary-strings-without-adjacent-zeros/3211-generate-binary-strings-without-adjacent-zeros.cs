public class Solution {
    public IList<string> ValidStrings(int n) {
        bool Access(string str)
{
    for(int i=0; i< str.Length-1; i++)
    {
        if(str[i] == '0' && str[i+1]=='0')
        {
           return false;
        }
        
    }
    return true;
}

List<string> list = new List<string>();

int possibleCombinations = (int)Math.Pow(2, n);
//Console.WriteLine(possibleCombinations);

for (int i=0; i<possibleCombinations; i++)
{
   string str = "";
    str += Convert.ToString(i,2);
    //Console.WriteLine("str : "+str);
    while (str.Length < n)
    {
        str = "0"+str;
    }
    bool isAccess = Access(str);
    if(isAccess)
        list.Add(str);


}
return list;
    }
}