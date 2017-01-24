//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist). 
//Write program that reads an array of numbers and prints how many of them are larger than their neighbours.
//On the first line you will receive the number N - the size of the array
//On the second line you will receive N numbers separated by spaces - the array
//Print how many numbers in the array are larger than their neighbours

/*
6
-26 -25 -28 31 2 27
-> 2
*/

function countLargerThanNeighbours(args){
    let n = +args[0],
        numbers = args[1].split(" "),
        count = 0,
        arr = [];

    for(let i=0;i<n;i+=1){
        arr.push(+numbers[i]);
    }

    for(let i=0; i < arr.length-1;i+=1){
        if(arr[i] > arr[i-1] && arr[i] > arr[i+1]){
            count+=1;
        }
    }
    console.log(count);
}
countLargerThanNeighbours(["6","-26 -25 -28 31 2 27"]);