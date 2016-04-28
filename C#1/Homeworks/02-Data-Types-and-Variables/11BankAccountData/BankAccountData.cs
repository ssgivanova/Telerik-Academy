using System;

//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 
//3 credit card numbers associated with the account. 
//Declare the variables needed to keep the information for a single bank account 
//using the appropriate data types and descriptive names.

class BankAccountData
{
        static void Main()
        {
            string holderFirstName = "Ivan";
            string holderMiddleName = "Ivanov";
            string holderLastName = "Ivanov";
            decimal balance = 234567.45m;
            string bankName = "Raiffeisenbank";
            string IBAN = "BG80 BNBG 9661 1020 3456 78";
            string creditCard1 = "5319 6934 5673 0264";
            string creditCard2 = "5319 6934 5673 7895";
            string creditCard3 = "5319 6934 5673 3466";

            Console.WriteLine("Account Owner : {0} {1} {2}",holderFirstName,holderMiddleName,holderLastName);
            Console.WriteLine("Balance : {0:c2}",balance);
            Console.WriteLine("Bank name : {0}\nIBAN : {1}", bankName, IBAN);
            Console.WriteLine("Credit cards numbers :\n#1. {0}\n#2. {1}\n#3. {2}", creditCard1, creditCard2, creditCard3);
        }
}
