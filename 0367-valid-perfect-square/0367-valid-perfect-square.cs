public class Solution {
    public bool IsPerfectSquare(int num) {
        bool flag=false;
        for(int i=2;i<=num/2;i++){
            if(i*i == num){
                flag=true;
            }
        }
        if(num==1)
        return true;
        return flag;
    }
}