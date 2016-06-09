/*
 Write a program that replaces in a HTML document given as string all the tags  
 <a href="…">…</a>  with corresponding tags  [URL=…](…/URL) .

Input
•On the only input line you will receive a string

Output
•Print the string with replaced tags

Constraints
•Time limit: 0.1s
•Memory limit: 16MB

 <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
 -> 
 <p>Please visit [our site](http://academy.telerik.com) to choose a training course. Also visit [our forum](www.devbg.org) to discuss the courses.</p>


 * */

using System;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        string html = Console.ReadLine();

        /*
        //solution with indexOf
         * 
        //first search

        int indexOpeningLinkTag = html.IndexOf("<a href=\"");
        int indexStartUrlText = html.IndexOf("\">");
        int indexEndUrlText = html.IndexOf("</a>");
        int indexStartUrlSite = indexOpeningLinkTag + @"<a href=""".Length;
        int nextIndexToSearchFrom = 0;

        while (indexOpeningLinkTag != -1 && indexStartUrlText != -1 && indexEndUrlText != -1
                                   && indexStartUrlSite != -1)
        {
            //text link info = our site
            string urlText = html.Substring(indexStartUrlText + 2, indexEndUrlText - indexStartUrlText - 2);
            //Console.WriteLine(urlText);

            //text address site = http://academy.telerik.com
            string urlSite = html.Substring(indexStartUrlSite, indexStartUrlText - indexStartUrlSite);
            //Console.WriteLine(urlSite);

            //remove text address site from html
            html = html.Remove(indexStartUrlSite, urlSite.Length);

            //insert the link that was removed
            int indexStartUrlTextToInsert = html.IndexOf("</a>", nextIndexToSearchFrom);

            //int indexStartUrlTextToInsert = html.IndexOf("]");
            html = html.Insert(indexStartUrlTextToInsert + "</a>".Length, "(" + urlSite + ")");

            //find next indexes
            nextIndexToSearchFrom = indexStartUrlTextToInsert + urlSite.Length +2;

            indexOpeningLinkTag = html.IndexOf("<a href=\"", nextIndexToSearchFrom);
            indexStartUrlText = html.IndexOf("\">",nextIndexToSearchFrom);
            indexEndUrlText = html.IndexOf("</a>",nextIndexToSearchFrom);
            indexStartUrlSite = indexOpeningLinkTag + @"<a href=""".Length;
            
        }

        //replace opening and closing tags for link
        html = html.Replace("<a href=\"\">", "[");
        html = html.Replace("</a>", "]");
        
        Console.WriteLine(html);
        */

        //solution with regular expressions <a href =" ....text1 "> text2.... </a>->[text2...](text1...)
        string pattern = "(<a href=\")(.*?)(\">)(.*?)(</a>)";
        string replacement = "[$4]($2)";
        string htmlClean = Regex.Replace(html, pattern, replacement);

        Console.WriteLine(htmlClean);


        //string parsedHTML = Regex.Replace(text, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");

    }
}