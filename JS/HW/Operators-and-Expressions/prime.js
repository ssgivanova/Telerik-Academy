/*
function solve(args)
{
    var n = +args[0];

    var divider = 2;
    var prime;
    
    if(n < 0 ){
        n = n * (-1);
    }
    
    if(n===1 || n===0){
        prime = false;
    }
    else{
         do{
              if(n % divider === 0 )
                {
                    prime = true;
                    break;
                }
             
             divider += 1;
             prime =false;
         }while(n % divider != 0);    
    }
    console.log(prime);
}
*/
function solve(args)
{
    var n = +args[0];

    var divider = 2;
    var prime;
    
    if(n < 2 ){
        prime = false;
    }
    else{
        if(n === 2)
        {
            prime = true;
        }
        else
        {
            prime = true;
            do{
                if(n % divider === 0 )
                {
                    prime = false;
                    break;
                }
                divider += 1;
            }while(n > divider);
        }
    }
   console.log(prime);
}

solve(['2']);
solve(['23']);
solve(['-3']);
solve(['0']);
solve(['1']);