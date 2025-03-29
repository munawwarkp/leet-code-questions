/**
 * @param {number} celsius
 * @return {number[]}
 */
var convertTemperature = function(celsius) {
    const ans = []
    const kelvin = celsius + 273.15
    const farenheit = celsius * 1.80 + 32.00
    ans.push(kelvin,farenheit)
    return ans
    

};