/**
 * @param {number[]} nums
 * @return {number[]}
 */
var findDisappearedNumbers = function(nums) {
    const newArr = []
    const numsSet = new Set(nums)

    for(i=1; i<=nums.length; i++){
    if(!numsSet.has(i)){
        newArr.push(i)
    }

}
return newArr
};