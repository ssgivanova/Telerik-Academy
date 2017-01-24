// Write a program that finds all prime numbers in the range [1 ... N].
// Use the Sieve of Eratosthenes algorithm. 
// The program should print the biggest prime number which is <= N.

// On the first line you will receive the number N
// Print the biggest prime number which is <= N
// 2 <= N <= 10 000 000
// Time limit: 0.3s
// Memory limit: 64MB

function biggestPrimeNumber(args){
    let n = +args[0],
        maxDivider = Math.sqrt(n),
        primeNumbers = [],
        biggestPrime = 0,
        divider = 2,
        prime = true;

    //find all the prime numbers
    // for(let i=1;i<=n;i+=1){
    //     for(let number=2;number<maxDivider;number+=1){
    //         //find which number is prime
    //         if(number % divider === 0){
    //             //not prime
    //             prime = false; 
    //             break;
    //         }
    //         //prime
    //         prime = true;
    //         primeNumbers.push(number);
    //         // if(number <= n){
    //         //     biggestPrime = number;
    //         // }
            
    //         // //find biggest prime <= n
    //         // if(number > biggestPrime){
    //         //     biggestPrime = number;
    //         // }
         
    //         divider += 1;
    //     }
    // }

    
    console.log(biggestPrime);
    console.log(primeNumbers);
}

biggestPrimeNumber(['13']);
biggestPrimeNumber(['126']);
biggestPrimeNumber(['26']);