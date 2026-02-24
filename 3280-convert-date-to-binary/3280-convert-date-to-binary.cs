public class Solution {
    public string ConvertDateToBinary(string date) {
 var res = Convert.ToDateTime(date);
 int year = res.Year;
 int day = res.Day;
 int month = res.Month;

 string binaryYr = Convert.ToString(year, 2);
 string binaryMonth = Convert.ToString(month,2);
 string binaryDay = Convert.ToString(day, 2);

string binaryDate = binaryYr+"-"+ binaryMonth + "-" + binaryDay;

return binaryDate;
    }
}