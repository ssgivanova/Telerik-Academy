//Write a program that finds the most frequent number in an array of N elements.
// On the first line you will receive the number N
// On the next N lines the numbers of the array will be given

// Print the most frequent number and how many time it is repeated
// Output should be REPEATING_NUMBER (REPEATED_TIMES times)

function countMostFrequentNumber(args){
    let n = +args[0],
        numbers = [],
        count = 1,
        maxCount = 1,
        frequentNumber=0;

    for(let i = 1; i < args.length; i+= 1){
        numbers.push(+args[i]);
    }

    numbers.sort();
    //console.log(numbers);

    for(let i = 0; i < numbers.length; i+=1){
        if(numbers[i+1] === numbers[i]){
            count += 1;
            if( count > maxCount){
                maxCount = count;
                frequentNumber = numbers[i];
            }
        }else{
                count = 1;
        }
    }
    console.log(frequentNumber + " (" + maxCount + " times)");
}

countMostFrequentNumber(['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3']);
//4 (5 times)