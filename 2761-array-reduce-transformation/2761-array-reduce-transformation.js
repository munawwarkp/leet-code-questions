/**
 * @param {number[]} nums
 * @param {Function} fn
 * @param {number} init
 * @return {number}
 */
var reduce = function(nums, fn, init) {
    let val=0;
    if(nums.length == 0){
        return init;
    }
    for(i=0; i<nums.length;i++){
        if(i!=0){
           val = fn(val,nums[i]);
        }else{
            val = fn(init,nums[i])

        }
    }
    return val;
};