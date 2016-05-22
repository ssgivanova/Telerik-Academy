using System;
class ParseTags
{
   static void Main()
   {
       //string text = Console.ReadLine();
       string text = "We are living in a <upcase> yellow submarine </upcase>. We don't have <upcase> anything </upcase> else.";

       //string tag = "upcase";
       //string result = UpperCaseInTags(text, tag);
       //Console.WriteLine(result);
              
       string startTag = "<upcase>";
       string endTag = "</upcase>";

       string result= string.Empty;

       //find first occurences
       int indexStartTag = text.IndexOf(startTag);

       while (indexStartTag != -1)
       {
           int indexEndTag = text.IndexOf(endTag);
           string temp = text.Substring(indexStartTag + startTag.Length, indexEndTag - indexStartTag - startTag.Length);
           text = text.Replace(startTag + temp + endTag, temp.ToUpper());

           //search next tag 
           indexStartTag = text.IndexOf(startTag);
       }

       Console.WriteLine(text);
       
   }

   public static string UpperCaseInTags(string text, string tag)
   {
       string startTag = "<" + tag + ">";
       string endTag = "</" + tag + ">";
       while (text.IndexOf(startTag) != -1)
       {
           int indexStartTag = text.IndexOf(startTag);
           int indexEndTag = text.IndexOf(endTag);
           string temp = text.Substring(indexStartTag + startTag.Length, indexEndTag - indexStartTag - startTag.Length);
           text = text.Replace(startTag + temp + endTag, temp.ToUpper());
       }
       return text;
   }
}
