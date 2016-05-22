/*
 * Write a program that encodes and decodes a string using given encryption key (cipher).
•The key consists of a sequence of characters. 
•The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
*/

using System;
using System.Text;

class EncodeAndDecode
{
   static void Main()
   {
       string message = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day.";
       string key = "drink";

       string encrypted = Encrypt(message, key);
       Console.WriteLine(encrypted);

       string decrypted = Decrypt(encrypted, key);
       Console.WriteLine(decrypted);
       
   }

   static string Encrypt(string message, string key)
   {
       var encryptedMessage = new StringBuilder(message.Length);

       for (int i = 0; i < message.Length; i++)
       {
          encryptedMessage.Append((char)(message[i] ^ key[i % key.Length]));
       }
       return encryptedMessage.ToString();
   }

   static string Decrypt(string message, string key)
   {
       return Encrypt(message, key);
   }

}
