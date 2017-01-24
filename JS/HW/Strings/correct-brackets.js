function correctBrackets(args){
    let str = args[0],
        isCorrect = true,
        indexOpen = -1,
        indexClose = -1,
        countOpening = 0,
        countClosing = 0;

    //count number of brackets
    for(var i = 0; i < str.length; i+=1){
        if(str[i]=== '('){
            countOpening+=1;
        }
        if(str[i]=== ')'){
            countClosing+=1;
        }
    }
    //different number of brackets
    if(countOpening !== countClosing){
        isCorrect = false;
    }
    else{
        indexOpen = str.indexOf("(");
        indexClose = str.indexOf(")");   
        while(indexOpen !== -1 && indexClose !== -1){
                if(indexClose < indexOpen){
                    isCorrect = false;
                    break;
                }
        //looking for next brackets
        indexOpen = str.indexOf("(",indexOpen+1);
        indexClose = str.indexOf(")",indexClose+1);
        }
    }

    if(isCorrect){
       console.log("Correct"); 
    }else{
        console.log("Incorrect");
    }
}

correctBrackets(['((a+b)/5-d)']);
correctBrackets(['((a+b)/5-d']);
correctBrackets([')(a+b))']);
correctBrackets(['(a+b))(']);