//Write a program that finds the length of the maximal increasing sequence in an array of N integers.
// On the first line you will receive the number N
// On the next N lines the numbers of the array will be given

function maximalIncreasingSequence(args){
    let n = +args[0],
        numbersArr = [],
        countIncreasing = 1,
        maxIncreasingCount = 1;

    for(let i = 1; i < args.length; i+= 1){
        numbersArr.push(+args[i]);
    }
    
    for(let i = 0; i < numbersArr.length; i+= 1){
        if(numbersArr[i+1] > numbersArr[i]){
            countIncreasing+=1;
            if(countIncreasing > maxIncreasingCount){
                maxIncreasingCount = countIncreasing;
            }
        }else
        {
            countIncreasing=1;
        }
    }
    console.log(maxIncreasingCount);
}

maximalIncreasingSequence(['8', '7', '3', '2', '3', '4', '2', '2', '4']);
maximalIncreasingSequence(['8', '7', '3', '2', '3', '4', '5', '6', '4']);