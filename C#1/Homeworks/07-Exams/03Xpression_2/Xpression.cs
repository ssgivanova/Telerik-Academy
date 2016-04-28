using System;
using System.Threading;
using System.Globalization;

class Xpression
 {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string expression = Console.ReadLine();

            decimal result = 0;
            decimal resultBrackets = 0;

            char operation ='+';
            char operationBrackets = '+';

            bool inBrackets = false;
            int number = 0;

            foreach (char symbol in expression)
            {
                if (symbol == '=')
                {
                    break;
                }
                if (Char.IsDigit(symbol))
                {
                    number = symbol - '0';

                    if (!inBrackets)
                    {
                        switch (operation)
                        {
                            case '+': result += number; break;
                            case '-': result -= number; break;
                            case '*': result *= number; break;
                            case '%': result %= number; break;
                        }
                    }
                    else
                    {
                        switch (operationBrackets)
                        {
                            case '+': resultBrackets += number; break;
                            case '-': resultBrackets -= number; break;
                            case '*': resultBrackets *= number; break;
                            case '%': resultBrackets %= number; break;
                        }
                    }
                }

                if (symbol == '+' ||  symbol == '-' || symbol == '%' || symbol == '/')
                {
                    if (!inBrackets)
                    {
                        operation = symbol;
                    }
                    else 
                    {
                        operationBrackets = symbol;
                    }
                    
                }
                
                if (symbol == '(')
                {
                    inBrackets = true;
                    continue;
                }
                if (symbol == ')')
                {
                    inBrackets = false;
                    operationBrackets = operation;

                    switch (operationBrackets)
                    {
                        case '+': result += resultBrackets; break;
                        case '-': result -= resultBrackets; break;
                        case '*': result *= resultBrackets; break;
                        case '%': result %= resultBrackets; break;
                    }
                    resultBrackets = 0;
                }
            }

            Console.WriteLine("{0:f3}",result);
            //Console.WriteLine(resultBrackets);
        }
 }
