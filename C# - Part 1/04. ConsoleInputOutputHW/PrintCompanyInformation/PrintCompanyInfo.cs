//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, 
//age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.


using System;
class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Please enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Please enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Please enter company phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Please enter company fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Please enter company web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Please enter first name of manager: ");
        string firstName = Console.ReadLine();
        Console.Write("Please enter last name of manager: ");
        string lastName = Console.ReadLine();
        string fullName = firstName + lastName;
        Console.Write("Please enter age of manager: ");
        string age = Console.ReadLine();
        Console.Write("Please enter phone number of manager: ");
        string phoneManager = Console.ReadLine();

        Console.WriteLine(@"{0}
Address: {1}
Telephone: {2}
Fax: {3}
Web site: {4}
Manager: {5} (age: {6}, tel. {7})", companyName, companyAddress, phoneNumber, faxNumber, webSite, fullName, age, phoneManager);

    }
}