/**
 * @param {number[]} digits
 * @return {number[]}
 */
var plusOne = function(digits) {
    const newNum = digits.join('')
    const intNum = BigInt(newNum) + 1n
    const strNum = String(intNum).split('').map(num => Number(num))
    return strNum
};