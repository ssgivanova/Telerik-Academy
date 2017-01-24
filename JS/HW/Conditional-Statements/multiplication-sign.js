//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

function solve(args){
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];

    var sign = "+";

    if(a === 0 || b === 0 || c === 0){
        sign = "0";
    }
    else
    {
      if(a > 0 && b > 0 && c > 0){
        sign = "+";
       }
      if(a < 0 && b < 0 && c < 0){
         sign = "-";
       }  
    }
    
    
    if(a > 0){
         if((b < 0 && c > 0) || (b > 0 && c < 0)){
                sign = "-";
         }
    } 
    if(b > 0){
        if((a < 0 && c > 0) || (a > 0 && c < 0)){
                sign = "-";
        }
    }
    if(c > 0){
        if((a < 0 && b > 0) || (a > 0 && b < 0)){
                sign = "-";
        }
    }
   console.log(sign);
}

solve(['5', '2', '2']);
solve(['-2', '-2', '1']);
solve(['-2', '4', '3']);
solve(['0', '-2.5', '4']);
solve(['-1', '-0.5', '-5.1']);
solve(['2', '-2', '-3']);