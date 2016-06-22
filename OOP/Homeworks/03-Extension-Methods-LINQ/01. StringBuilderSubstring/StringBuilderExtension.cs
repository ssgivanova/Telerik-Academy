namespace _01.StringBuilderSubstring
{
    using System;
    using System.Linq;
    using System.Text;

    public static class StringBuilderExtension
    {
        //Implement an extension method Substring(int index, int length) for the class StringBuilder 
        //that returns new StringBuilder and has the same functionality as Substring in the class String.

        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            if (index < 0 || index > input.Length)
            {
                throw new IndexOutOfRangeException("Index is more than 0 or more than the length of the text");
            }
            if (length < 0 || length > input.Length - index)
            {
                throw new ArgumentException("Invalid lenght of the text");
            }
            StringBuilder sbSubstring = new StringBuilder();
            string text = input.ToString();
            for (int i = index; i <= length; i++)
            {
                sbSubstring.Append(text[i]);
            }
            return sbSubstring;
        }
    }

    

    
}
