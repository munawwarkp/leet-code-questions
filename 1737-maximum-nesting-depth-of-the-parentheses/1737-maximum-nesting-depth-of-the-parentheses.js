/**
 * @param {string} s
 * @return {number}
 */
var maxDepth = function(s) {
   var count=0;
    var res = 0;

  for(i=0;i<s.length;i++){
    if(s.charAt(i)=='('){
        count++
        if(count>res){
            res = count
        }
    }
    else if(s.charAt(i) == ')'){
        count--
       
    }
  }
  return res

};