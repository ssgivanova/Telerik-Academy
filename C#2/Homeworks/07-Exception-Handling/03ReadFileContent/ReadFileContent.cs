/*
Write a program that enters file name along with its full file path (e.g.  C:\WINDOWS\win.ini ),
reads its contents and prints it on the console
Find in MSDN how to use  System.IO.File.ReadAllText(...)
Be sure to catch all possible exceptions and print user-friendly error messages. 
 */

using System;
using System.IO;
using System.Text;

class ReadFileContent
{
    static void Main()
    {
        //string path = @"C:\WINDOWS\win.ini";
        string path = @"..\..\win.ini";

        try
        {
            string text = File.ReadAllText(path);
            Console.WriteLine(text);

        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (UnauthorizedAccessException unae)
        {
            Console.WriteLine(unae.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}