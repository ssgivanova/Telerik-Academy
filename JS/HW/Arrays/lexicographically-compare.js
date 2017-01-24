//lexicographically-compare.js

//Write a program that compares two char arrays lexicographically (letter by letter).
// On the first line you will receive the first char array as a string
// On the second line you will receive the second char array as a string

// Print < if the first array is lexicographically smaller
// Print > if the second array is lexicographically smaller
// Print = if the arrays are equal

function lexographCompare(args){
    var char1 = args[0],
        char2 = args[1],
        comparisonSign='',
        length = 0;

    if(char1.length < char2.length){
        length = char1.length;
    }else {
        length = char2.length;
    }

    for(var i=0;i<length;i+=1){
        if(char1[i]<char2[i]){
            comparisonSign = '<';
            break;
        }else if(char1[i]>char2[i]){
            comparisonSign = '>';
            break;
        }else{
            comparisonSign = '=';
        }
    }

    if ((comparisonSign === '=') && (char1.length < char2.length)){
        comparisonSign = '<';
    }

    if ((comparisonSign === '=') && (char1.length > char2.length)){
        comparisonSign = '>';
    }

    console.log(comparisonSign);
}

lexographCompare(['hello', 'halo']);
lexographCompare(['food', 'food']);
lexographCompare(['z', 'aaaaaaaaa']);