// You are given a text. Write a function that changes the text in all regions:

// <upcase>text</upcase> to uppercase.
// <lowcase>text</lowcase> to lowercase
// <orgcase>text</orgcase> does not change casing
// Note: Regions can be nested.

function parseTags(args){
    let str = args[0],
        strNoTags = [],
        indexUpOpen = -1,
        indexUpClose = -1,
        indexLowOpen = -1,
        indexLowClose = -1,
        indexOrgOpen = -1,
        indexOrgClose = -1,
        sentences = str.split("."),
        noTags ="";

    console.log(sentences);

     for (var i = 0; i < sentences.length; i++) {

         var start=0, strToCopy ="";

         //no tags
         if(sentences[i].indexOf("<")===-1){
            strNoTags.push(sentences[i]); 
            noTags += sentences[i] + ".\n";
         }
         else
         {
            
            //orgcase
            indexOrgOpen = sentences[i].indexOf("<orgcase>");
            if(indexOrgOpen !== -1){            
                result = sentences[i].trim().replace("<orgcase>","").replace("</orgcase>","");
                
            }

            //upcase
            indexUpOpen = sentences[i].indexOf("<upcase>");
            indexUpClose = sentences[i].indexOf("</upcase>");
            if(indexUpOpen !== -1 && indexUpClose !== -1){
                start = indexUpOpen + 8; 
                strToCopy = sentences[i].substring(start,indexUpClose);              
                result = result.trim().replace("<upcase>","").replace(strToCopy,strToCopy.toUpperCase()).replace("</upcase>","");
                //strNoTags.push(result);
                
            }

            //lowcase
            indexLowOpen = sentences[i].indexOf("<lowcase>");
            indexLowClose = sentences[i].indexOf("</lowcase>");
                if(indexLowOpen !== -1 && indexLowClose){
                start = indexLowOpen + 9;  
                strToCopy = sentences[i].substring(start,indexLowClose);
                result = result.trim().replace("<lowcase>","").replace(strToCopy,strToCopy.toLowerCase()).replace("</lowcase>","");
                
                //strNoTags.push(result);
                }
            noTags += result + ".\n";

        }
            

         /*
         if(sentences[i].indexOf("<")===-1){
            strNoTags.push(sentences[i]); 
         }
         else{ //there is a tag
            
            indexOrgOpen = words[i].indexOf("<orgcase>");
            if(indexOrgOpen !== -1){
             //find the end
             indexOrgClose = words[i].indexOf("</orgcase>");
             console.log(indexOrgOpen + "-" + indexOrgClose);
             start = indexOrgOpen + 9;  
             strToCopy = words[i].substring(start,indexOrgClose);
             //console.log(strToCopy);
             strNoTags.push(strToCopy);         
            }
            indexLowOpen = words[i].indexOf("<lowcase>");
            if(indexLowOpen !== -1){
                 indexLowClose = words[i].indexOf("</lowcase>");
             //console.log(indexLowOpen + "-" + indexLowClose);
             start = indexLowOpen + 9;  
             strToCopy = words[i].substring(start,indexLowClose);
             //console.log(strToCopy.toLowerCase());
             strNoTags.push(strToCopy.toLowerCase());
             }

             indexUpOpen = words[i].indexOf("<upcase>");
             if(indexUpOpen !== -1){
                 indexUpClose = words[i].indexOf("</upcase>");
             //console.log(indexUpOpen + ":" + indexUpClose);
                 if(indexUpClose !== -1) {
                    start = indexUpOpen + 9;  
                    strToCopy = words[i].substring(start,indexUpClose); 
                 }else{
                    strToCopy = words[i].substring(start-1);      
                 }

             //console.log(strToCopy.toUpperCase());
             strNoTags.push(strToCopy.toUpperCase());
             }
             */
        //}
    }
     //console.log(strNoTags.join(".\n"));
     console.log(noTags);
}

//parseTags([ 'We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.' ]);
parseTags([ 'Hello.We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We doN\'t have <lowcase>Anything</lowcase> else.' ]);
//result :
//We are liViNg in a YELLOW SUBMARINE. We doN't have anything else.