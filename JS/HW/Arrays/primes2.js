function biggestPrimeNumber(args){
    let n = +args[0],
        maxDivider = Math.sqrt(n),
        primeNumbers = [n+1],
        biggestPrime = 0,
        divider = 2,
        prime = true;

       

        //create list with all numbers from 2 to n
        for (let i = 2; i < primeNumbers.length; i+=1){
            primeNumbers.push(true);
            //primeNumbers[i] = true;
        }
         console.log(primeNumbers);

        for (let i = 2; i < primeNumbers.length; i+=1)
        {
            //if primes[i] is not marked as false - then it's prime (=true)
            //check all numbers 2*i + i - if they are not false, they are the primes
            if (primeNumbers[i] === true)
            {   
                for (let j = 2*i; j < primeNumbers.length; j=j+i)
                {
                    primeNumbers[j] = false;
                }
                biggestPrime = i;
            }
        }
         console.log(biggestPrime);
}

biggestPrimeNumber(['13']);
biggestPrimeNumber(['126']);
biggestPrimeNumber(['26']);


