// Write a function that extracts the content of a html page given as text. The function should return anything that is in a tag, without the tags.
// The input will consist of an array of strings
// The output should be consisted of one line - text inside tags

function extract(args){
    var html = [],
        extracted = "";

    for(var i = 0;i< args.length; i+=1){
        html.push(args[i].trim());
    }

    //console.log(html);

    for(var i = 0;i< html.length; i+=1){
        var text ="";
        var indexTextEnd = html[i].indexOf("</");
        var indexTextStart = html[i].indexOf(">");
        var indexTagStart = html[i].indexOf(">");
        
        //no tags
        if(indexTagStart === -1 && indexTextStart === -1 && indexTextEnd === -1){
            extracted += html[i];
            //extracted += html[i].trim();
        }
        
        //only opening tags - < and >
        if(indexTagStart !== -1 && indexTextStart !== -1 && indexTextEnd === -1){
            extracted += html[i].substring(indexTextStart+1).trim(); 
        }
        
        
        //there's opening and closing tag and the text we search is between
        while(indexTextEnd !== -1 && indexTextStart !== -1 && indexTextStart < indexTextEnd){

            //look for the start and end of opening tag
            extracted += html[i].substring(indexTextStart+1,indexTextEnd).trim();
                              
            indexTextEnd = html[i].indexOf("</",indexTextEnd+1);
            indexTextStart = html[i].indexOf(">",indexTextStart+1);
        }
    }
    
    console.log(extracted);


}

extract([
    '<html>     ',
    '  <head>',
    '    <title>Sample site    </title>   ',
    '  </head>',
    '  <body>',
    '    <div>text',
    '      <div>more text  </div>',
    '      and more...',
    '    </div>',
    '    in body',
    '  </body>',
    '</html>'
]);

//result :
// Sample sitetextmore textand more...in body