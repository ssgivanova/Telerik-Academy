//Using loops implement a javascript function that converts a hex number 
//number to its decimal representation.

//['FE'] -> 254
//['1AE3'] -> 6883

function solve(args){
    var hexStr = args[0];
    //var array = Array.from(hexStr);
    var array = hexStr;
    var number = 0;

    for(var i = array.length -1;i >= 0; i-=1){
        var digit = array[i];
        
        switch(digit){
            case "A" : digit = 10; break;
            case "B" : digit = 11; break;
            case "C" : digit = 12; break;
            case "D" : digit = 13; break;
            case "E" : digit = 14; break;
            case "F" : digit = 15; break;
            default : digit = parseInt(array[i]);
        }
        var power = array.length - i -1;
        number += digit * (Math.pow(16,power));
    }
    
    console.log(number);
}

solve(['FE']);
solve(['1AE3']);
solve(['4ED528CBB4']);