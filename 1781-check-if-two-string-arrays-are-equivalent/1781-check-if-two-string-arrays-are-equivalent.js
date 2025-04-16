/**
 * @param {string[]} word1
 * @param {string[]} word2
 * @return {boolean}
 */
var arrayStringsAreEqual = function(word1, word2) {
    const a = word1.reduce((acc,val) => {
        return acc+=val
    })
    const b = word2.reduce((acc,val) => {
        return acc += val
    })
    return a === b
};