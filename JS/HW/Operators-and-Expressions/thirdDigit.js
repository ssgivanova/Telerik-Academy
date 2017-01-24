//Implement a javascript function that takes an array with a single element - an integer N as parameter 
//and prints true if the third digit of N is 7, 
//or "false THIRD_DIGIT", where you should print the third digits of N.

function solve(args){
    
    let n = +args[0];
    
    let digit = ((n / 100 | 0) % 10) ;
        
    if(digit === 7){
        console.log("true ");
    }else{
        console.log("false " + digit);
    }

    
}

solve(['123456']);
solve(['5']);
solve(['701']);
solve(['9703']);
solve(['877']);
solve(['777877']);
solve(['9999799']);