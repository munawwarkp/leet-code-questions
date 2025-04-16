/**
 * @param {number[][]} accounts
 * @return {number}
 */
var maximumWealth = function(accounts) {
   const summedAcc =  accounts.map(account => {
        return account.reduce((acc,val) => {
            return acc += val
        },0)
    })
    return Math.max(...summedAcc)
};