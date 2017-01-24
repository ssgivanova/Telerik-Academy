//process.stdout.write(`${index},`);
process.stdout.write("hello: ");
console.log("Mary");


var number = 2, output = [];
while (number <=10) {
    output.push(number);
    number += 2;
}
console.log.apply(console, output);


var output = ""; 
for (var i = 2; i <= 10; i = i + 2) {
    output += i + " "; 
}
console.log(output);


//min number
console.log(Number.MIN_VALUE);
console.log(0 < Number.MIN_VALUE);

console.log(Number.MIN_SAFE_INTEGER);
console.log(0 < Number.MIN_SAFE_INTEGER);

console.log(Number.NEGATIVE_INFINITY);