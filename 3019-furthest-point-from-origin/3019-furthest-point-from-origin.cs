public class Solution {
    public int FurthestDistanceFromOrigin(string moves) {
        int RCount = 0;
        int LCount = 0;
        int underScoreCount=0;
        for(int i=0;i<moves.Length;i++){
            if(moves[i]=='R'){
                RCount++;
            }
            if(moves[i]=='L'){
                LCount++;
            }
            if(moves[i] == '_'){
                underScoreCount++;
            }
        }
        if(RCount>LCount){
            return underScoreCount+RCount-LCount;
        }else{
            return underScoreCount+LCount-RCount;
        }
    }
}