//Write a method that returns the last digit of given integer as an English word. 
//Write a program that reads a number and prints the result of the method.'
//42 -> two

function getLastDigit(args){
    let number = +args[0],
        word ="",
        digit = number % 10;

    switch(digit){
        case 0 : word = "zero";break;
        case 1 : word = "one";break;
        case 2 : word = "two";break;
        case 3 : word = "three";break;
        case 4 : word = "four";break;
        case 5 : word = "five";break;
        case 6 : word = "six";break;
        case 7 : word = "seven";break;
        case 8 : word = "eight";break;
        case 9 : word = "nine";break;
        default : word = "not a digit";break; 
    }
    console.log(word);
}

getLastDigit([42]);
getLastDigit([100]);
getLastDigit([1573]);