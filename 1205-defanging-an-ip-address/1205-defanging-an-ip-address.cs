public class Solution {
    public string DefangIPaddr(string address) {
        var defangedIp = address.Replace(".","[.]");
        return defangedIp;
    }
}