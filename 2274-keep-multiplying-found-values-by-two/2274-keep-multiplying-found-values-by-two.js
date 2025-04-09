/**
 * @param {number[]} nums
 * @param {number} original
 * @return {number}
 */
var findFinalValue = function(nums, original) {
   let sum = 0
   for(let i=0; i<nums.length; i++){
    if(nums[i] === original){
        sum = nums[i]*2
        original = sum
        i = -1
    }else{
        sum = original
    }
   }
   return sum
 
   
};