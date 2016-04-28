using System;
class Conductors
{
     static void Main()
     {
         int perf = int.Parse(Console.ReadLine());
         int n = int.Parse(Console.ReadLine());

         string perfStr = Convert.ToString(perf, 2).PadLeft(32, '0');
         //Console.WriteLine(perfStr);

         //count 1 and remove additionnal bits 
         //calculate the length of perf to be used

         char prev = '*';
         int rightIndex = 0;
         int leftIndex = 0;
         string bitsP = "";
         for (int i = perfStr.Length - 1; i >= 0; i--)
         {
             if (perfStr[i] == '1')
             {
                 if (prev == '*')
                 {
                     //first occurence of 1
                     prev = perfStr[i];
                     rightIndex = i;
                 }
                 //last occurence of 1
                 leftIndex = i;
             }
         }

         //make new string with these bits only
         for (int j = leftIndex; j <= rightIndex; j++)
         {
             bitsP += perfStr[j];
         }
         //Console.WriteLine(rightIndex);
         //Console.WriteLine(leftIndex);
         Console.WriteLine(bitsP);

         //searched bits
         int k = bitsP.Length;
         //Console.WriteLine("k="+k);

         int count = 0;

         //read n numbers

         string newTicketStr = "";

         for (int i = 0; i < n; i++)
         {
             int ticket = int.Parse(Console.ReadLine());

             string ticketStr = Convert.ToString(ticket, 2).PadLeft(32, '0');
             Console.WriteLine(ticketStr);

             char bit = '*';
             bool found = false;
             int countCoincidance = 0;

             for (int pn = 31; pn >=k-1; pn--)
             {
                 //Console.WriteLine("pn {0}", pn);
                 for (int ps =k - 1 ; ps >=0; ps--)
                 {
                     //Console.WriteLine("pn {0}, ps {1}-> {2} ? {3}",pn,ps,ticketStr[pn],bitsP[ps]);
                     if (ticketStr[pn] == bitsP[ps])
                     {
                         if (ticketStr[pn] == '1')
                         {
                             Console.WriteLine("first coincidance found");
                             countCoincidance++;
                             break;
                             //newTicketStr += '0';
                         }
                         else
                         {
                             newTicketStr += ticketStr[pn];
                         }
                         found = true;
                         count++;
                     }
                     else
                     {
                         found = false;
                     }
                 }
                 Console.WriteLine("New number : " + newTicketStr);
             }
             Console.WriteLine(count);
         }
     }
}
