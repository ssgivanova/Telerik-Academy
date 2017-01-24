//Implement a javascript function that accepts an array with a single element - positive integer N as string 
//and prints all the numbers from 1 to N inclusive, on a single line, separated by a whitespace.

function solve(args){
    var n = +args[0];

    var numbers = "";

    for(var i=1;i<=n;i+=1){
        numbers += i +" ";
    }
    console.log(numbers);
}

solve(['5']);
solve(['1']);

