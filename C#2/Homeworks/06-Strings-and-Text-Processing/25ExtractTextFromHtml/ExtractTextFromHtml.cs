/*
Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

Example input:
<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>


Output: 

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.

 */

using System;
using System.Text.RegularExpressions;

class ExtractTextFromHtml
{
    static void Main()
    {
        //string html = Console.ReadLine();
        string html = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
           

        string title = "";
        string body = "";

        int indexTitleStart = html.IndexOf("<title>");
        int indexTitleEnd = html.IndexOf("</title>");

        if (indexTitleStart != -1 && indexTitleEnd != -1)
        {
            int countTitleTag = "<title>".Length;
            title = html.Substring(indexTitleStart + countTitleTag, indexTitleEnd - indexTitleStart - countTitleTag);
        }

        int indexBodyStart = html.IndexOf("<body>");
        int countBodyTag = "<body>".Length; 
        int indexBodyEnd = html.IndexOf("</body>");

        if (indexBodyStart != -1 && indexBodyEnd != -1)
        {
            body = html.Substring(indexBodyStart + countBodyTag, indexBodyEnd - indexBodyStart - countBodyTag);
            Console.WriteLine(body);
        }

        Console.WriteLine();

        //output
        if (title != string.Empty)
        {
            Console.WriteLine("Title : {0}", title);
        }
        else
        {
            Console.WriteLine("Title not available");
        }
        
        //remove not needed tags
        // content between < and > -> to be removed
        // and between </ and  >   -> to be removed but add additional space after >

        int indexOpeningTag = body.IndexOf("<");
        int indexClosingTag = body.IndexOf(">");

        string text = body;
        while (indexOpeningTag != -1 && indexClosingTag != -1)
        {
            string contentToRemove = text.Substring(indexOpeningTag+1, indexClosingTag - indexOpeningTag-1);
            
            //case </a>
            if (contentToRemove[0] == '/')
            {
                text = text.Insert(indexClosingTag + 1, " ");
            }
            text = text.Remove(indexOpeningTag, contentToRemove.Length + 2);

            

            //int indexNext = 0;

            indexOpeningTag = text.IndexOf("<");
            indexClosingTag = text.IndexOf(">");
        }

        if (text != string.Empty)
        {
            Console.WriteLine("Text : {0}", text.Trim());
        }
        else
        {
            Console.WriteLine("Text not available");
        }


        Console.WriteLine();

        // SOLUTION WITH REGULAR EXPRESSIONS
        string titleR = GetTitleRegex(html);
        
        string textR = GetTextRegex(html);

        if (titleR != string.Empty)
        {
            Console.WriteLine("Title : {0}", titleR);
            Console.WriteLine("Text : {0}", textR);
        }
        else
        {
            Console.WriteLine("Title not available");
            Console.WriteLine("Text : {0}", textR);
        }

    }

    private static string GetTextRegex(string input)
    {
        string text = Regex.Match(input, @"<\s*body\s*>.*?<\s*/\s*body\s*>").ToString();
        return Regex.Replace(text, @"<.*?>", String.Empty);
    }

    private static string GetTitleRegex(string input)
    {
        string head = Regex.Match(input, @"<\s*head\s*>.*?<\s*/\s*head\s*>").ToString();
        if (head == String.Empty || !head.Contains("title"))
        {
            return string.Empty;
        }

        string title = Regex.Match(head, @"<\s*title\s*>.*?<\s*/\s*title\s*>").ToString();
        title = Regex.Replace(title, @"<\s*title\s*>", String.Empty);
        title = Regex.Replace(title, @"<\s*/\s*title\s*>", String.Empty);

        return title.Trim();
    }

}