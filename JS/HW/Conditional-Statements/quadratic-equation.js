//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
//and solves it (prints its real roots). Calculates and prints its real roots.
//Note: Quadratic equations may have 0, 1 or 2 real roots.

//The output should be a single line containing the real roots (see sample tests)
//Print numbers with two digits of precision after the floating point
//If there are two roots then x1 < x2

function solve(args){
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];

    var d = b*b - 4*a*c;

    if(d < 0){
        console.log("no real roots");
    }else if(d === 0){
        var x = -b/(2*a);
        console.log("x1=x2=" + x.toFixed(2));
    }else{
        var x1 = (-b + Math.sqrt(d))/(2 * a);
        var x2 = (-b - Math.sqrt(d))/(2 * a);

        if(x1 < x2){
            //x1=0.00; x2=3.00
            console.log("x1="+x1.toFixed(2)+"; x2=" + x2.toFixed(2));
        }else{
            console.log("x1="+x2.toFixed(2)+"; x2=" + x1.toFixed(2));
        }
    }
}

solve(['2', '5', '-3']);
solve(['-1', '3', '0']);
solve(['-0.5', '4', '-8']);
solve(['5', '2', '8']);
solve(['0.2', '9.572', '0.2']);