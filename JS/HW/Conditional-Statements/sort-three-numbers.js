//Sort 3 real values in descending order. Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

function solve(args){
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];

    var max = Number.MAX_SAFE_INTEGER;
    var min = Number.MIN_SAFE_INTEGER;
    var middle = Number.MIN_SAFE_INTEGER;

     if(a >= b){
         if(c > a){
             min = b;middle = a; max = c;
         }else if(c < a && c > b){
             min = b;middle = c; max = a;
         }else {
             min = c;middle = b; max = a;
        }
     }else if(a < b){
         if(c > b){
             min = a;middle = b; max = c;
         }else if(c < b && c > a){
             min = a;middle = c; max = b;
         }else {
             min = c;middle = a; max = b;
        }
     }
    console.log(max + " " + middle + " " + min);
}

solve(['5', '1', '2']);
solve(['-2', '-2', '1']);
solve(['-2', '4', '3']);
solve(['0', '-2.5', '5']);
solve(['-1.1', '-0.5', '-0.1']);
solve(['10', '20', '30']);
solve(['1', '1', '1']);