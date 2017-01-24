'use strict';

function solve(args) {
    //var n = +args[0], // cast string to Number
    var n = parseInt(args[0]);
    
    var divisible = (n%5===0 && n%7===0);
        
    if(divisible){
            console.log("true "+n);
        
    }else{
        console.log("false "+n);
    }
}

solve(['0']);
solve(['5']);
solve(['7']);
solve(['35']);