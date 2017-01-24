// Write a JavaScript function that reverses a string.

// The input will consist of an array containing one string
// The output should be consisted of one line - the reversed string

function reverseString(args){
    let str = args[0],
        reversed ='';

for(let i = str.length-1; i>=0;i-=1){
        reversed += str[i];
    }
    console.log(reversed);
}

reverseString(['sample']);
reverseString(['qwertytrewq']);