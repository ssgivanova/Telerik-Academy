//Write an if statement that takes two double variables a and b and exchanges their values if the first one is 
//greater than the second. 
//As a result print the values a and b, separated by a space.

function solve(args){
    var a = +args[0];
    var b = +args[1];

    if(a > b){
        //exchange them
        var temp = a;
        a = b;
        b = temp;
    }
    console.log(a + " " + b);
}

solve(['5', '2']);
solve(['3', '4']);
solve(['5.5', '4.5']);