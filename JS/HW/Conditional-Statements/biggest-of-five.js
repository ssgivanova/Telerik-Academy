//Write a script that finds the biggest of given 5 variables. Use nested if statements.

function solve(args){
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];
    var d = +args[3];
    var e = +args[4];

    var biggest = Number.MIN_SAFE_INTEGER;

    if(a > biggest){
        biggest = a;
    }
    if(b > biggest){
        biggest = b;
    }
    if(c > biggest){
        biggest = c;
    }
    if(d > biggest){
        biggest = d;
    }
    if(e > biggest){
        biggest = e;
    }
    console.log(biggest);
}

solve(['5', '2', '2', '4', '1']);
solve(['-2', '-22', '1', '0', '0']);
solve(['-2', '4', '3', '2', '0']);
solve(['0', '-2.5', '0', '5', '5']);
solve(['-3', '-0.5', '-1.1', '-2', '-0.1']);