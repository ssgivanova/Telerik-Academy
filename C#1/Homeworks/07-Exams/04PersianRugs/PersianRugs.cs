using System;

// \  \.../  /
// #\  \./  /#
// ##\     /##
// ###\   /###
// ####\ /####
// #####X#####
// ####/ \####
// ###/   \###
// ##/     \##
// #/  /.\  \#
// /  /...\  \
class PersianRugs
{
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int w = 2 * n + 1;
            int countMiddleSpace = 0;
            int availableMiddleSpace = 0;

            for (int i = 0; i < n; i++)
            {
                countMiddleSpace = w-2-2*i;
                   
                Console.Write(new String('#',i));
                Console.Write('\\');
                //Console.Write(new String(' ',countMiddleSpace));

                //middle dots
                //calculate the space between the middle #\ and /#
                //if there's not enough place for \ and \ and middle dots - print only space
                
                availableMiddleSpace = countMiddleSpace - 2 * d;

                // available space = middle - 1*\ - 1*/ 
                if (availableMiddleSpace < 2)
                {

                    Console.Write(new String(' ', countMiddleSpace));
                }
                else
                {
                    //remove the space for \ and / - the left place is for the dots
                    availableMiddleSpace -= 2;
                    Console.Write(new String(' ', d));
                    Console.Write('\\');
                    Console.Write(new String('.', availableMiddleSpace));
                    Console.Write('/');
                    Console.Write(new String(' ', d));
                }
                
                Console.Write('/');
                Console.Write(new String('#', i));
                Console.WriteLine();
            }



            //middle line
            Console.Write(new String('#', n));
            Console.Write('X');
            Console.Write(new String('#', n));
            Console.WriteLine();

            //mirror 
            for (int i = n-1; i >= 0; i--)
            {
                countMiddleSpace = w - 2 * i - 2;
                Console.Write(new String('#', i));
                Console.Write('/');
                         
                //if there's not enough place for \ and \ and middle dots - print only space
                availableMiddleSpace = countMiddleSpace - 2 * d;

                // available space = middle - 1*\ - 1*/ 
                if (availableMiddleSpace < 2)
                {
                    Console.Write(new String(' ', countMiddleSpace));
                }
                else
                {   //remove the space for \ and / - the left place is for the dots
                    availableMiddleSpace -= 2;
                    Console.Write(new String(' ', d));
                    Console.Write('/');
                    Console.Write(new String('.', availableMiddleSpace));
                    Console.Write('\\');
                    Console.Write(new String(' ', d));
                }

                Console.Write('\\');
                Console.Write(new String('#', i));
                Console.WriteLine();
            }
        }
 }
