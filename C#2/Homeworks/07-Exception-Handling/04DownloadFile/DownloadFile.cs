/*
Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current 
directory. Find in Google how to download files in C#. 
Be sure to catch all exceptions and to free any used resources in the finally block.
https://telerikacademy.com/Content/Images/news-img01.png
 * */

using System;
using System.Net;
using System.IO;

class DownloadFile
{
    static void Main()
    {
        string url = "https://telerikacademy.com/Content/Images/news-img01.png";

        //get filename and extension from the url
        int indexFilenameStart= url.LastIndexOf("/");
        string filename = url.Substring(indexFilenameStart+1, url.Length - indexFilenameStart-1);
        string uri = url.Substring(0, indexFilenameStart);

        // Create a new WebClient instance.
        WebClient webClient = new WebClient();

        Console.WriteLine("Downloading file {0} from {1}",filename,uri);

        try
        {
            webClient.DownloadFile(url, filename);
            Console.WriteLine("Download Successful at {0}", Directory.GetCurrentDirectory());
        }
        catch (UriFormatException ufe)
        {
            Console.WriteLine("Download failed");
            Console.WriteLine(ufe.Message);
        }
        catch (HttpListenerException hle)
        {
            Console.WriteLine("Download failed");
            Console.WriteLine(hle.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine("Download failed");
            Console.WriteLine(ae.Message);
        }
        catch (WebException we)
        {
            Console.WriteLine("Download failed");
            Console.WriteLine(we.Message);
        }
        catch (UnauthorizedAccessException unae)
        {
            Console.WriteLine("Download failed");
            Console.WriteLine(unae.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine("Download failed");
            Console.WriteLine(nse.Message);
        }
        finally
        {
            webClient.Dispose();
        }
    }
}
