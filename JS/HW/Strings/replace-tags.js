// Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [TEXT](URL).

// The input will consist of an array containing one string
// The output should be consisted of one line

function replaceTags(args){

    var html = args[0],
        replaced = '',
        linkStartIndex = -1,
        linkEndIndex = -1,
        textStartIndex = -1,
        remainingTextIndex =0;

    linkStartIndex = html.indexOf("<a href=");
    linkEndIndex = html.indexOf("</a>");
    textStartIndex = html.indexOf(">",linkStartIndex);

    while(linkStartIndex !== -1 && linkEndIndex !== -1 && textStartIndex !== -1){
                var text = html.substring(textStartIndex+1,linkEndIndex );
                var link = html.substring(linkStartIndex + "<a href=".length +1,textStartIndex-1);

                replaced += html.substring(remainingTextIndex,linkStartIndex);                
                replaced += "[" + text + "]";
                replaced += "(" + link + ")";
                remainingTextIndex = linkEndIndex +"</a>".length;

                //look for the next
                linkStartIndex = html.indexOf("<a href=",linkStartIndex+1);
                linkEndIndex = html.indexOf("</a>", linkEndIndex+1);
                textStartIndex = html.indexOf(">",linkStartIndex+1);
                if( linkStartIndex === -1){
                    replaced += html.substring(remainingTextIndex,html.length);
                }
    }
    console.log(replaced);    
}

replaceTags([ '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>' ]);
//<p>Please visit [our site](http://academy.telerik.com) to choose a training course. Also visit [our forum](www.devbg.org) to discuss the courses.</p>