function sortArray(args){

    function getMaximal(startIndex, arr){
        let max = Number.MIN_SAFE_INTEGER;
        for(let i=startIndex;i<arr.length;i+=1){
            if(arr[i]>max){
                max = arr[i];
            }
        }
        return max;
    }

    let n = +args[0],
        numbersStr = args[1].split(" "),
        numbersArr = [], sortedArr = [],
        max = 0, maxIndex = 0;

    for(let i=0;i<n;i+=1){
        numbersArr.push(+numbersStr[i]);
    }
    
    //console.log("numbers to sort : " + numbersArr);

    while(numbersArr.length>0){
        for(let i = 0; i < numbersArr.length; i+=1){
            max = getMaximal(i,numbersArr);
            maxIndex = numbersArr.indexOf(max); 
            
            //console.log("size = " + numbersArr.length + ", max=[" + max + "] maxIndex : " + maxIndex);
            
            //swap with the last index if max is not the last element
            if(maxIndex !== numbersArr.length - 1){
                let temp = numbersArr[numbersArr.length - 1];
                numbersArr[numbersArr.length - 1] = max;
                numbersArr[maxIndex] = temp;
            }
            sortedArr.push(max);
            numbersArr.pop();
            //console.log(numbersArr);
            break;
        }
    }
    sortedArr.reverse()
    console.log("sorted : " + sortedArr);
}

sortArray(["6","3 4 1 5 2 6"]);
sortArray(["10", "36 10 1 34 28 38 31 27 30 20"]);