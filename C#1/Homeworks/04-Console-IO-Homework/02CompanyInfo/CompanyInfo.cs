using System;

//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//• Write a program that reads the information about a company and its manager and prints it back on 
//the console.

//Input
//•You will each piece of information about the company on a separate line, in the same order as in the example i.Company name
//ii.Company address
//iii.Phone number
//iv.Fax number
//v.Web site
//vi.Manager first name
//vii.Manager last name
//viii.Manager age
//ix.Manager phone


//Output
//•Print the information the same way as shown in the sample test. Make sure that you print "(no fax)" if an empty line is passed as fax number.

//Constraints
//•Only the fax number field can be empty, all other fields will have be least one symbol

class CompanyInfo
{
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();

            string faxNumber = Console.ReadLine();
            if (faxNumber == String.Empty)
            {
                faxNumber = "(no fax)";
            }
                                    
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            byte managerAge = byte.Parse(Console.ReadLine());
            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}", companyName,companyAddress,phoneNumber);
            Console.Write("Fax: {0}\n", faxNumber);
            Console.WriteLine("Web site: {0}\nManager: {1} {2} (age: {3}, tel. {4}) ",
                webSite, managerFirstName, managerLastName, managerAge, managerPhoneNumber);

        }
}
