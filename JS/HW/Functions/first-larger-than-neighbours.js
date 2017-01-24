//Write a method that returns the index of the first element in array that is larger than its neighbours, 
//or -1, if there is no such element.

//On the first line you will receive the number N - the size of the array
//On the second line you will receive N numbers sepated by spaces - the array

function firstLarger(args){
    let n = +args[0],
        numbersStr = args[1].split(" "),
        numbersArr = [],
        indexFirstLarger = -1;

    for(let i=0;i<n;i+=1){
        numbersArr.push(+numbersStr[i]);
    }

    for(let i=0;i<n-1;i+=1){
        if(numbersArr[i] > numbersArr[i-1] && numbersArr[i] > numbersArr[i+1]){
            indexFirstLarger = i;
            break;
        }
    }
    console.log(indexFirstLarger);
}

firstLarger(["6", "-26 -25 -28 31 2 27"]);
firstLarger(["6", "-26 -30 -28 31 2 27"]);