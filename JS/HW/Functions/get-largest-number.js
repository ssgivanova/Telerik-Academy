//Write a method GetMax() with two parameters that returns the larger of two integers. 
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
//On the first line you will receive 3 integers separated by spaces

//first solution
function solve1(args){

    function getMax(a,b){
        //let max = Math.max(a,b);
        let max = (a > b)? a : b;
        return max; 
    }

    let line = args[0];
    let numbersStr = line.split(' ');
    let arr = [];
    for( let n of numbersStr){
        arr.push(+n);
    }

    //console.log(arr);
    let max = Number.MIN_SAFE_INTEGER;
    for( let value of arr){
        if(getMax(max,value)>max){
            max = value;
        }
    }
    console.log(max);
}

//second solution
function solve(args){

    function getMax(a,b){
        //let max = Math.max(a,b);
        let max = (a > b)? a : b;
        return max; 
    }

    let numbersArr = args[0].split(" ").map(Number);
    let a = numbersArr[0],
        b = numbersArr[1],
        c = numbersArr[2];

    let max = getMax(getMax(a,b),c);    
    console.log(max);
}

solve(["8 3 6"]);
solve(["7 19 19"]);