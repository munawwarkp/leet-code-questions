/**
 * @param {number} n
 * @return {string}
 */
var countAndSay = function(n) {
    if(n===1) return "1"
    const prev = countAndSay(n-1)
    var res = ""
    var count = 1
    for(i=1;i<prev.length;i++){
        if(prev[i] == prev[i-1]){
            count++
        }else{
            res += count + prev[i - 1];
             count = 1
        }
    }
    res += count+prev[prev.length - 1]
    return res
};