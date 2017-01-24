//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
//Use the Selection sort algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest, 
//move it at the second position, etc.

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given

function selectionSort(args){
    let n = +args[0],
        numbersArr = [],
        min = Number.MAX_SAFE_INTEGER,
        minIndex = 0;

    for(let i = 1; i < args.length; i+= 1){
        numbersArr.push(+args[i]);
    }

    for(let i = 0; i < n-1; i +=1){
        //reset min value in each iteration
        min = Number.MAX_SAFE_INTEGER;
        for(let j = i; j < n; j+=1){
            //find the smallest element
             if(numbersArr[j] < min){
                min = numbersArr[j];
                minIndex = j;
            }
        }
        if(minIndex!== i){
            //swap the elements - move it to the first position
            let temp = numbersArr[i];
            numbersArr[i] = numbersArr[minIndex];
            numbersArr[minIndex] = temp;
            //console.log("swap - i= " + i + ", min :" + min + " , index : " + minIndex );
            //console.log(numbersArr);
        }
    }
    //print numbers - Each number should be on a new line
    for(let value of numbersArr){
        console.log(value);
    }
}

//selectionSort(['6', '3', '4', '1', '5', '2', '6']);
selectionSort(['10', '36', '10', '1', '34', '28', '38', '31', '27', '30', '20']);