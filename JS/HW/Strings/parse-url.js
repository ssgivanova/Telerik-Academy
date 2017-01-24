
// Write a script that parses an URL address given in the format: 
// [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

// The input will consist of an array containing one string
// The output should be consisted of three line

function parseUrl(args){

    var url = args[0],
        protocol ="", server = "", resource = "";

    var indexEndProtocol = url.indexOf("://");
    protocol = url.substring(0,indexEndProtocol);

    var indexEndServer = url.indexOf("/",indexEndProtocol+3);
    server = url.substring(indexEndProtocol+3,indexEndServer);

    resource = url.substring(indexEndServer);

    console.log("protocol: " + protocol);
    console.log("server: " + server);
    console.log("resource: " + resource);
}

parseUrl([ 'http://telerikacademy.com/Courses/Courses/Details/239' ]);
//protocol: http
// server: telerikacademy.com
// resource: /Courses/Courses/Details/239