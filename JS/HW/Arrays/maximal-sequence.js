//Write a program that finds the length of the maximal sequence of equal elements 
//in an array of N integers.
// On the first line you will receive the number N
// On the next N lines the numbers of the array will be given

function maximalSequence(args){
    let n = +args[0],
        numbersArr = [],
        count = 1,
        maxCount = 1;

    for(let i = 1; i < args.length; i+= 1){
        numbersArr.push(+args[i]);
    }
    
    for(let i = 0; i < numbersArr.length; i+= 1){
        if(numbersArr[i+1] === numbersArr[i]){
            count+=1;
            if(count > maxCount){
                maxCount = count;
            }
        }else
        {
            count=1;
        }
    }
    console.log(maxCount);
}

maximalSequence(['10', '2', '1', '1', '2', '3', '3', '2', '2', '2', '1']);