//Write a method that counts how many times given number appears in a given array. 
//Write a test program to check if the method is working correctly
//On the first line you will receive a number N - the size of the array -> 1 <= N <= 1024
//On the second line you will receive N numbers separated by spaces - the numbers in the array
//On the third line you will receive a number X

/*
function solve(args){
    let n = +args[0];
    let line = args[1];
    let x = +args[2];
    let numbers = line.split(" ");
    let arr = [];

    for(let i=0;i<n;i+=1){
        arr.push(+numbers[i]);
    }
    let count = countNumber(arr,x);

    console.log(count);
}

function countNumber(arr,number){
    let count = 0;

    for(let value of arr){
        if(value === number){
            count += 1;
        }
    }
    return count;
}
*/

function countNumber(args){
    let n = +args[0],
        numbers = args[1].split(' '),
        x = +args[2],
        count = 0;

    for(let i=0;i<n;i+=1){
        if(+numbers[i] === x){
            count += 1;
        }
    }    
    console.log(count);
}

countNumber(['8','28 6 21 6 -7856 73 73 -56','73']);