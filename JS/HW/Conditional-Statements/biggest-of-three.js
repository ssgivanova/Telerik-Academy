function solve(args){
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];

    var biggest = Number.MIN_SAFE_INTEGER;

    if(a >= b)
    {
        if(c > a){
            biggest = c;
        }else if(c <= a){
            biggest = a;
        }
    }else if(a < b)
    {
        if(c > b){
            biggest = c;
        }else if( c <= b){
            biggest = b;
        }
    }
    console.log(biggest);
}


solve(['5', '2', '2']);
solve(['-2', '-2', '1']);
solve(['-2', '4', '3']);
solve(['0', '-2.5', '5']);
solve(['-0.1', '-0.5', '-1.1']);
solve(['4', '5', '1']);