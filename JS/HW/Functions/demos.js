function sortArray(args){

    function getMaximal(startIndex, arr){
        var max = Number.MIN_SAFE_INTEGER;

        for(var i=startIndex;i<arr.length;i+=1){
            if(arr[i]>max){
                max = arr[i];
            }
        }
        return max;
    }

    var n = +args[0],
        numbersStr = args[1].split(" "),
        numbersArr = [],
        sortedArr = [],
        max = 0, maxIndex = 0;

        //numbersArr = args[1].split(" ").map(Number);

    for(var i=0;i<n;i+=1){
        numbersArr.push(+numbersStr[i]);
    }
  
     while(numbersArr.length>0){
       max = getMaximal(0,numbersArr);
       maxIndex = numbersArr.indexOf(max);
       
       //swap with the last index if max is not the last element
       if(maxIndex !== numbersArr.length - 1){
            var temp = numbersArr[numbersArr.length - 1];
            numbersArr[numbersArr.length - 1] = max;
            numbersArr[maxIndex] = temp;
        } 
        sortedArr.push(max);
        numbersArr.pop();
    }

    /*
    for(var i = 0; i < numbersArr.length; i+=1){
            max = getMaximal(i,numbersArr); 
            maxIndex = numbersArr.indexOf(max);           
                  
            //swap with the first index 
            if(maxIndex !== i){
                var temp = numbersArr[i];
                numbersArr[i] = max;
                numbersArr[maxIndex] = temp;
                
            }
    }
    */
    
    sortedArr.reverse(); 
    var output="";
    for(var i = 0; i < sortedArr.length; i+=1){
        output += sortedArr[i];
        if(i < sortedArr.length - 1){
            output +=" ";
        }
    }
    console.log(output);
}

sortArray(["6","3 4 1 5 2 6"]);
sortArray(["10", "36 10 1 34 28 38 31 27 30 20"]);