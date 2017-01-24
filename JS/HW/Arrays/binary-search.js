// Write a program that finds the index of given element X in a sorted array of N integers by using 
//the Binary search algorithm.

// On the first line you will receive the number N
// On the next N lines the numbers of the array will be given
// On the last line you will receive the number X

// Print the index where X is in the array
// If there is more than one occurence print the first one
// If there are no occurences print -1

function binarySearch(args){

    function selectionSort(arr){
        for(let i = 0; i < arr.length-1; i +=1){
            //reset min value in each iteration
            min = Number.MAX_SAFE_INTEGER;
            for(let j = i; j < arr.length; j+=1){
                //find the smallest element
                if(arr[j] < min){
                    min = arr[j];
                    minIndex = j;
                }
            }
            if(minIndex!== i){
                //swap the elements - move it to the first position
                let temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }

    let n = +args[0],
        numbersArr = [],
        x = + args[args.length-1];
        index = -1,
        start = 0,
        end = n-1,
        middleIndex = -1;

    for(let i = 1; i < args.length-1; i+= 1){
        numbersArr.push(+args[i]);
    }
    
    selectionSort(numbersArr);
    //console.log(numbersArr);

    //iterative solution
    
    while (start <= end){
            middleIndex = (start + end)/2 | 0;
            if (x == numbersArr[middleIndex])
            {
                index = middleIndex;
                break;
            }
            else if (x < numbersArr[middleIndex])
            {
                end = middleIndex - 1;
            }
            else
            {
                start = middleIndex + 1;
            }
            //calculate new middle 
            middleIndex = (start + end) / 2;
    }

    if (start > end)
        {
            //element not present
            index = -1;
    }
    

    //recursive solution\
    //index = BinarySearchMethod(0, n,  numbersArr, x);
   console.log(index);

}

function BinarySearchMethod(start, end, arr, value ) {
        var middleIndex = (start + end) / 2 | 0;

        if (start > end)
        {
            return -1;
        }

        if (value == arr[middleIndex])
        {
            return middleIndex;
        }
        else if (value < arr[middleIndex])
        {
            return BinarySearchMethod(0, middleIndex - 1, arr, value);
        }
        else
        {
            return BinarySearchMethod(middleIndex + 1, arr.Length, arr, value);
        }
}

binarySearch(['10', '1', '2', '4', '8', '16', '31', '32', '64', '77', '99', '32']);
