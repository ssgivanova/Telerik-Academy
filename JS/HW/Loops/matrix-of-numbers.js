//Write a javascript function that prints a matrix like in the examples below by a given integer N. 
//Use two nested loops.


function solve(args){
    var n = +args[0];
    var output="";

    for(var i=0; i<n;i+=1){
        for(var j=i+1;j<=n+i;j+=1){
            output += j + " ";
        }
       output+= "\n";
    }
    console.log(output);

}


solve(['3']);
solve(['2']);