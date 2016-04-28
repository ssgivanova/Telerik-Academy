using System;
using System.Threading;
using System.Globalization;

class Xpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input = Console.ReadLine();
        decimal result = 0m;
        decimal tempResult = 0m;

        //declaration of variables for outside of brackets
        char operation = '+'; // +, -, /, *
        //EL:char operationBeforeBrackets = '+';
        decimal operand1 = 0m;
        decimal operand2 = 0m;

        //declaration of variables in the brackets - EL
        char bracketOperation = '+';
        decimal bracketOperand1 = 0m;
        decimal bracketOperand2 = 0m;
        bool startedOperationInBrackets = false;

        bool openedBrackets = false;
        bool startedOperation = false; // when we have operand1 and operation and are waiting for operand2
        bool setOfOperand2IsDone = false; //EL

        foreach (char ch in input)
        {
            //EL: decimal resultBrackets = 0;
            //Evaluate end of expression
            if (ch == '=')
            {
                break;
            }

            //set operation - EL
            if ((ch == '+') || (ch == '-') || (ch == '*') || (ch == '/'))
            {
                if (openedBrackets)
                {
                    bracketOperation = ch;
                }
                else
                {
                    operation = ch;
                }
            }

            //set brackets - EL
            if (ch == '(')
            {
                openedBrackets = true;
            }

            if (ch == ')')
            {
                if ((startedOperationInBrackets) && (startedOperation))
                {
                    operand2 = tempResult;
                    setOfOperand2IsDone = true;
                }
                else
                {
                    operand1 = tempResult;
                    startedOperation = true;
                }
                startedOperationInBrackets = false;
                openedBrackets = false;
                
            }
            
            //set operand1 and operand2 - EL
            if (Char.IsDigit(ch))
            {
                if (openedBrackets)
                {
                    if (!startedOperationInBrackets)
                    {
                        bracketOperand1 = ch - '0';
                        tempResult = bracketOperand1;
                        startedOperationInBrackets = true;
                    }
                    else
                    {
                        bracketOperand2 = ch - '0';
                        setOfOperand2IsDone = true;
                    }
                }
                else
                {
                    if (!startedOperation)
                    {
                        operand1 = ch - '0';
                        startedOperation = true;
                    }
                    else
                    {
                        operand2 = ch - '0';
                        setOfOperand2IsDone = true;
                    }
                }
            }

            //calculate expression without brackets - EL
            if ((!openedBrackets) && (setOfOperand2IsDone))
            {
                switch (operation)
                {
                    case '+': result = operand1 + operand2; break;
                    case '-': result = operand1 - operand2; break;
                    case '*': result = operand1 * operand2; break;
                    case '/': result = operand1 / operand2; break;
                    default: Console.WriteLine("Invalid operator"); break;
                }

                operand1 = result;
                setOfOperand2IsDone = false;
            }
            //calculate expression in brackets - EL
            if ((openedBrackets) && (setOfOperand2IsDone))
            {
                switch (bracketOperation)
                {
                    case '+': tempResult = bracketOperand1 + bracketOperand2; break;
                    case '-': tempResult = bracketOperand1 - bracketOperand2; break;
                    case '*': tempResult = bracketOperand1 * bracketOperand2; break;
                    case '/': tempResult = bracketOperand1 / bracketOperand2; break;
                    default: Console.WriteLine("Invalid operator"); break;
                }

                bracketOperand1 = tempResult;
                setOfOperand2IsDone = false;
            }

            ////EL: calculate expression
            //if (Char.IsDigit(ch))
            //{
            //    if (!startedOperation)
            //    {
            //        operand1 = ch - '0';
            //        result = operand1;
            //    }
            //    else
            //    {
            //        operand2 = ch - '0';
            //        operand1 = (decimal)result;

            //        switch (operation)
            //        {
            //            case '+':
            //                if (!openedBrackets) 
            //                { 
            //                    result = operand1 + operand2; 
            //                }
            //                else
            //                {   resultBrackets = operand1 + operand2; 
            //                    operand2 = resultBrackets;
            //                    //operand1 = resultBrackets;
            //                    //operand2 = result;
            //                }
            //                break;
                            
            //            case '-':
            //                if (!openedBrackets) 
            //                { 
            //                    result = operand1 - operand2; 
            //                }
            //                else
            //                {
            //                    resultBrackets = operand1 - operand2;
            //                    operand2 = resultBrackets;
            //                }
            //                break;
                            
            //            case '*':
            //                if (!openedBrackets) { result = operand1 * operand2; }
            //                else
            //                {
            //                    resultBrackets = operand1 * operand2;
            //                    operand2 = resultBrackets;
            //                }
            //                break;
            //            case '/':
            //                if (!openedBrackets) { result = (decimal)operand1 / operand2; }
            //                else
            //                {
            //                    resultBrackets = (decimal) operand1 / operand2;
            //                    operand2 = resultBrackets;
            //                }
            //                break;
            //            case '(': 
            //                openedBrackets = true;
            //                break;

            //            case ')': 
            //                openedBrackets = false;
            //                operand1 = tempResult;
            //                operand2 = resultBrackets;
            //                resultBrackets = 0;
            //                break;
            //            default: break;
            //        }

            //        //Console.WriteLine("{0} {1} {2} = {3}", operand1, operation, operand2, result);

            //        startedOperation = false;
            //    }
            //}
            //else
            //{
            //    // operation
            //    operation = ch;
                                     
            //    if (!(ch == '(' || ch == ')'))
            //    {
            //        startedOperation = true;
            //        if (!openedBrackets)
            //        {
            //            operationBeforeBrackets = operation;
            //        }
            //    }
            //    else
            //    {
            //        if (ch == '(') 
            //        { 
            //            openedBrackets = true;
            //            startedOperation = false;
            //            tempResult = result;
            //        }
            //        if (ch == ')') 
            //        { 
            //            openedBrackets = false;
            //            operation = operationBeforeBrackets;
            //            operand1 = tempResult;

            //            switch (operation)
            //            {
            //                case '+': result = operand1 + operand2; break;
            //                case '-': result = operand1 - operand2; break;
            //                case '*': result = operand1 * operand2; break;
            //                case '/': result = (decimal)operand1 / operand2; break;
                            
            //            }
            //        }
            //    }                
            //}
        }
        Console.WriteLine("{0:f2}", result);
    }
}
