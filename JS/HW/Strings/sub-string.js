// Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

// The input will consist of an array containing one string
// The output should be consisted of one line - the number of matches

function countSubstring(args){
    let search = args[0].toLowerCase(),
        str = args[1].toLowerCase(),
        count = 0,
        searchIndex = -1,
        startingIndex = 0;

    for(let i = 0; i <= str.length; i+=1){
        searchIndex = str.indexOf(search,startingIndex);
        while(searchIndex !== -1){
            count += 1;
            //console.log("at index " + searchIndex);

            //move the start ot the searching
            startingIndex = searchIndex + search.length;
            searchIndex = str.indexOf(search,startingIndex);
        }
    }
    console.log(count);
}

countSubstring([
    'In',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);

countSubstring([
    'you',
    'Hello,how are you?Come in my home. You are welcome'
]);

