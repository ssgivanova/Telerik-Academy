//Write a function that replaces non breaking white-spaces in a text with &nbsp.
//The input will consist of an array containing one string
//The output should be consisted of one line

function replaceSpace(args){
    var text = args[0],
        words = text.split(" "),
        result ='';

   result = words.join("&nbsp;")
   console.log(result);

   //regular expression
   console.log(text.replace(/\s/g,"&nbsp;" ));  

}

replaceSpace([ 'hello world' ]);
replaceSpace([ 'This text contains 4 spaces!!' ]);