using System;
using System.IO;

/*Write a program that parses an URL address given in the format: [protocol]://[server]/[resource]
and extracts from it the  [protocol] ,  [server]  and  [resource]  elements.

Input
•On the only line you will receive an address

Output
•Print the protocol, server and resource as shown below

Constraints
•Time limit: 0.1s
•Memory limit: 16MB

 http://telerikacademy.com/Courses/Courses/Details/212 
[protocol] = http
[server] = telerikacademy.com
[resource] = /Courses/Courses/Details/212  
 
 */


class ParseUrl
{
   static void Main()
   {
       string url = Console.ReadLine();

       string protocol = "[protocol] = ";
       string server = "[server] = ";
       string resource = "[resource] = ";

       int indexEndProtocol = url.IndexOf("://");
       protocol += url.Substring(0, indexEndProtocol);

       Console.WriteLine(protocol);

       //server
       char slash = Path.AltDirectorySeparatorChar; // '/'
       int indexStartServer = indexEndProtocol + 3; // server part start after 2 slash after the protocol
       int indexEndServer = url.IndexOf(slash,indexStartServer);
       server += url.Substring(indexStartServer, indexEndServer - indexStartServer);

       Console.WriteLine(server);

       //resource
       resource += url.Substring(indexEndServer);
       Console.WriteLine(resource);
   }
}
