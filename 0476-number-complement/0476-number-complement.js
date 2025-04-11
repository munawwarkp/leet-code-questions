/**
 * @param {number} num
 * @return {number}
 */
var findComplement = function(num) {
    const binary = num.toString(2) 

    let compliment = ''
    for(i=0; i<binary.length; i++){
        if(binary[i] === '0'){
            compliment += 1
        }else{
            compliment += 0
        }
    }
    return parseInt(compliment,2)
};