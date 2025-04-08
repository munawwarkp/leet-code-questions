/**
 * @param {number[]} digits
 * @return {number[]}
 */
var plusOne = function(digits) {
    const num = BigInt(digits.join('')) + 1n
    return String(num).split('').map(num => Number(num))

};