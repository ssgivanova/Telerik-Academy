//Implement a javascript function that accepts an array of floating-point numbers as strings 
//and returns the minimal, the maximal number, the sum and the average of all numbers 
//(displayed with 2 digits after the decimal point).

/*
min=3.00
max=6.00
sum=9.00
avg=4.50
*/

function solve(args){

    //var min = 10000;
    //var max = -10000;
    //var sum = 0;
    
    var min = +args[0];
    var max = +args[0];
    var sum = +args[0];
    var avg = 0;

    for(var i=1; i<args.length; i+=1){
        //read element
        var n = +args[i];
        sum += n;

        if(n < min){
            min = n;
        }
        if(n > max){
            max = n;
        }
        
    }
    avg = sum / args.length;
     
    console.log("min=" + min.toFixed(2));
    console.log("max=" + max.toFixed(2));
    console.log("sum=" + sum.toFixed(2));
    console.log("avg=" + avg.toFixed(2));

}

solve(['2', '5', '1']);
solve(['2', '-1', '4']);