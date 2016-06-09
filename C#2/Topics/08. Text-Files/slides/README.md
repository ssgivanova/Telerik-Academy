<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Text Files
## Reading and Writing Text Files
<img class="slide-image" src="\imgs\pic00.png" style="top:52.89%; left:69.53%; width:33.89%; z-index:-1" />
<img class="slide-image" src="\imgs\pic01.png" style="top:50.96%; left:91.69%; width:16.03%; z-index:-1" />
<img class="slide-image" src="\imgs\pic02.png" style="top:53.67%; left:49.19%; width:17.08%; z-index:-1" />
<img class="slide-image" src="\imgs\pic03.png" style="top:5.92%; left:5%; width:19.55%; z-index:-1" />
<img class="slide-image" src="\imgs\pic04.png" style="top:40%; left:12%; width:28.77%; z-index:-1" />
<img class="slide-image" src="\imgs\pic05.png" style="top:40%; left:14%; width:22.16%; z-index:-1" />
<div class="signature">
	<p class="signature-course">C# Advanced</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="https://telerikacademy.com" class="signature-link">https://telerikacademy.com</a>
</div>




<!-- section start -->
<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Table of Contents
- What is Stream?
  - Stream Basics
- Reading Text Files
  - The **StreamReader** Class
- Writing Text Files
  - The **StreamWriter** Class
- Handling I/O Exceptions
<img class="slide-image" src="\imgs\pic06.png" style="top:57.30%; left:76.72%; width:27.18%; z-index:-1" />
<img class="slide-image" src="\imgs\pic07.png" style="top:14.17%; left:76.71%; width:26.87%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# What Is Stream?
## Streams Basic Concepts
<img class="slide-image" src="\imgs\pic08.png" style="top:52%; left:35.79%; width:30%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# What is Stream?
- Stream is the natural way to transfer data in the computer world
- To read or write a file, we open a stream connected to the file and access the data through the stream
<img class="slide-image" src="\imgs\pic09.png" style="top:53.82%; left:24.33%; width:55.54%; z-index:-1" />
<img class="slide-image" src="\imgs\pic10.png" style="top:48.68%; left:3.74%; width:25.00%; z-index:-1" />
<img class="slide-image" src="\imgs\pic11.png" style="top:47.60%; left:79.20%; width:25.00%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Streams Basics
- Streams are used for reading and writing data into and from devices
- Streams are **ordered sequences ofbytes**
  - Provide consecutive access to its elements
- Different types of streams are available to access different data sources:
  - File access, network access, memory streams and others
- Streams are open before using them and closed after that




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Reading Text Files
<img class="slide-image" src="\imgs\pic12.png" style="top:42%; left:37.16%; width:35.81%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# The StreamReader Class
- **System.IO.StreamReader**
  - The easiest way to read a text file
  - Implements methods for reading text lines and sequences of characters
  - Constructed by file name or other stream
    - Can specify the text encoding
    - For Cyrillic use **UTF8**
  - Works like **Console.Read()** / **ReadLine()** but over text files


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# StreamReader Methods
- **newStreamReader(fileName)**
  - Constructor for creating reader from given file
- **ReadLine()**
  - Reads a single text line from the stream
  - Returns **null** when end-of-file is reached
- **ReadToEnd()**
  - Reads all the text until the end of the stream
- **Close()**
  - Closes the stream reader


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Reading a Text File
- Reading a text file and printing its content to the console:

```cs
StreamReader reader = new StreamReader("test.txt");
string fileContents = reader.ReadToEnd();
Console.WriteLine(fileContents);
streamReader.Close();
```

- Specifying the text encoding:

```cs
StreamReader reader = new StreamReader(
    "cyr.txt", Encoding.UTF8;
// Read the file contents here ...
reader.Close();
```

<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Using StreamReader – Practices
- The **StreamReader** instances should always be closed by calling the **Close()** method
  - Otherwise system resources can be lost
- In C# the preferable way to close streams and readers is by the "**using**" construction

```cs
using (<stream object>)
{
   // Use the stream here. It will be closed at the end
}
```

  - It automatically calls the **Close()**after the **using** construction is completed


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Reading a Text File – _Example_
- Read and display a text file line by line:

```cs
StreamReader reader =
    new StreamReader("somefile.txt");
using (reader)
{
    int lineNumber = 0;
    string line = reader.ReadLine();
    while (line != null)
    {
        lineNumber++;
        Console.WriteLine("Line {0}: {1}",
            lineNumber, line);
        line = reader.ReadLine();
    }
}
```

<img class="slide-image" src="\imgs\pic13.png" style="top:19.39%; left:88.89%; width:15.21%; z-index:0" />


<!-- attr: { id:'', class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Reading Text Files
## [Demo]()
<img class="slide-image" src="\imgs\pic14.png" style="top:52%; left:36.85%; width:30%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Writing Text Files
## Using the StreamWriter Class
<img class="slide-image" src="\imgs\pic15.png" style="top:52%; left:27.82%; width:45%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# The StreamWriter Class
- **System.IO.StreamWriter**
  - Similar to **StreamReader**, but instead of reading, it provides writing functionality
- Constructed by file name or other stream

```cs
StreamWriter streamWriter =
   new StreamWriter("test.txt",
      false, Encoding.UTF8);
```

  - Can define encoding
  - For Cyrillic use “**UTF8**"

```cs
StreamWriter streamWriter =
   new StreamWriter("test.txt");
```



<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# StreamWriter Methods
- **Write()**
  - Writes string or other object to the stream
  - Like **Console.Write()**
- **WriteLine()**
  - Like **Console.WriteLine()**
- **Flush()**
  - Flushes the internal buffers to the hard drive
- **AutoFlush**
  - Flush the internal buffer after each writing


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Writing to a Text File – _Example_
- Create text file named "**numbers.txt**" and print in it the numbers from 1 to 20 (one per line):

```cs
StreamWriter streamWriter =
    new StreamWriter("numbers.txt");
using (streamWriter)
{
    for (int number = 1; number <= 20; number++)
    {
        streamWriter.WriteLine(number);
    }
}
```

<img class="slide-image" src="\imgs\pic16.png" style="top:26.01%; left:89.12%; width:16.53%; z-index:-1" />


<!-- attr: { id:'', class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Writing Text Files
## [Demo]()
<img class="slide-image" src="\imgs\pic17.png" style="top:52%; left:30.75%; width:40%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Handling I/O Exceptions
## Introduction
<img class="slide-image" src="\imgs\pic18.png" style="top:52%; left:29.71%; width:38%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# What is Exception?
- "An event that occurs during the execution of the program that disrupts the normal flow of instructions“ – definition by Google
  - Occurs when an operation can not be completed
- Exceptions tell that something unusual has happened, e. g. error or unexpected event
- I/O operations throw exceptions when operation cannot be performed (e.g. missing file)
  - When an exception is thrown, all operations after it are not processed


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# How to Handle Exceptions?
- Using **try{}**, **catch{}** and **finally{}** blocks:

```cs
try
{
    // Some exception is thrown here}
catch (<exception type>)
{    // Exception is handled here
}
finally
{
    // The code here is always executed, no
    // matter if an exception has occurred or not   }
```

<img class="slide-image" src="\imgs\pic19.png" style="top:20.28%; left:81.40%; width:22.04%; z-index:0" />


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Catching Exceptions
- Catch block specifies the type of exceptions that is caught
  - If **catch** doesn’t specify its type, it catches all types of exceptions

```cs
try
{
  StreamReader reader = new StreamReader("file.txt");
  Console.WriteLine("File successfully open.");
}
catch (FileNotFoundException)
{
  Console.Error.WriteLine(
    "Can not find 'somefile.txt'.");
}
```



<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size: 40px;' } -->
# Handling Exceptions When Opening a File

```cs
try
{
   StreamReader streamReader = new StreamReader(
    "c:\\NotExistingFileName.txt");
}
catch (System.NullReferenceException exc)
{
   Console.WriteLine(exc.Message);
}
catch (System.IO.FileNotFoundException exc)
{
   Console.WriteLine(
    "File {0} is not found!", exc.FileName);
}
catch
{
   Console.WriteLine("Fatal error occurred.");
}
```



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Handling I/O Exceptions
<img class="slide-image" src="\imgs\pic20.png" style="top:42%; left:9.36%; width:30%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Reading and Writing Text Files
<img class="slide-image" src="\imgs\pic21.png" style="top:35%; left:9.36%; width:23%; z-index:-1" />
<img class="slide-image" src="\imgs\pic22.png" style="top:42.31%; left:61.95%; width:38.57%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Counting Word Occurrences – _Example_
- Counting the number of occurrences of the word "**foundme**" in a text file:

```cs
StreamReader streamReader =
 new StreamReader(@"..\..\somefile.txt");
int count = 0;
string text = streamReader.ReadToEnd();
int index = text.IndexOf("foundme", 0);
while (index != -1)
{
   count++;
   index = text.IndexOf("foundme", index + 1);
}
Console.WriteLine(count);
```

<div class="fragment balloon" style="top:68.30%; left:67.88%; width:31.44%">What is missing in this code?</div>


<!-- attr: { id:'', class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Counting Word Occurrences
## [Demo]()
<img class="slide-image" src="\imgs\pic23.png" style="top:52%; left:21.89%; width:55%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Reading Subtitles – _Example_

- We are given a standard movie subtitles file:

```cs
.....

{2757}{2803} Allen, Bomb Squad, Special Services...
{2804}{2874} State Police and the FBI!
{2875}{2963} Lieutenant! I want you to go to St. John's Emergency...
{2964}{3037} in case we got any walk-ins from the street.
{3038}{3094} Kramer, get the city engineer!
{3095}{3142} I gotta find out a damage report. It's very important.
{3171}{3219} Who the hell would want to blow up a department store?

.....
```

<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Fixing Subtitles – _Example_
- Read subtitles file and fix it’s timing:

```cs
static void Main()
{
  try
  {
    // Obtaining the Cyrillic encoding
    System.Text.Encoding encodingCyr =
      System.Text.Encoding.UTF8;
    // Create reader with the Cyrillic encoding
    StreamReader streamReader =
      new StreamReader("source.sub", encodingCyr);
    // Create writer with the Cyrillic encoding
    StreamWriter streamWriter =
      new StreamWriter("fixed.sub",
        false, encodingCyr);

```
_(example continues)_


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Fixing Subtitles – _Example_

```cs
    try
    {
      string line;
      while (
        (line = streamReader.ReadLine()) != null)
      {
        streamWriter.WriteLine(FixLine(line));
      }
    }
    finally
    {
      streamReader.Close();
      streamWriter.Close();
    }
  }
  catch (System.Exception exc)
  {
    Console.WriteLine(exc.Message);
  }
}
```

<div class="fragment balloon" style="top:40.33%; left:58.18%; width:43.20%">**FixLine(line)** perform fixes on the time offsets: multiplication or/and addition with constant</div>


<!-- attr: { id:'', class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Fixing Movie Subtitles
## [Demo]()
<img class="slide-image" src="\imgs\pic24.png" style="top:52%; left:30%; width:42%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Summary
- Streams are the main I/O mechanismsin .NET
- The **StreamReader** class and **ReadLine()** method are used to read text files
- The **StreamWriter** class and **WriteLine()** method are used to write text files
- Always put file handling in **using(…)** block
- Exceptions are unusual events or error conditions
  - Can be handled by **try-catch-finally** blocks


<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Text Files
## Questions?
<img class="slide-image" src="\imgs\pic25.png" style="top:49.66%; left:4.68%; width:38.79%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - [csharpfundamentals.telerik.com](csharpfundamentals.telerik.com)
  - Telerik Software Academy
    - [academy.telerik.com](academy.telerik.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Software Academy Forums
    - [forums.academy.telerik.com](forums.academy.telerik.com)
<img class="slide-image" src="\imgs\pic26.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1" />
<img class="slide-image" src="\imgs\pic27.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1" />
<img class="slide-image" src="\imgs\pic28.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1" />
<img class="slide-image" src="\imgs\pic29.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1" />
