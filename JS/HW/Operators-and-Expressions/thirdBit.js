//Using bitwise operators, write a javascript function(that accepts a single array with arguments as a parameter) that uses an expression to find the value of the bit at index 3 of an 
//unsigned integer read from the console.

function solve(args){
    var n = +args[0];

    var index = 3;
    var bit = ((1 << index) & n) >> index ;

    console.log(n.toString(2));
    console.log(bit);
}

solve(['15']);
solve(['1024']);