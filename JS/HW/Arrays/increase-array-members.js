//Write a program that allocates array of N integers, initializes each element by 
//its index multiplied by 5 and the prints the obtained array on the console.

function increaseArray(args){
    let n = +args[0],
        arr = [];

    for(let i = 0; i < n; i+=1){
        arr.push(i*5);
        console.log(arr[i]);
    }

}

increaseArray(["5"]);