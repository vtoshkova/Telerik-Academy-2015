//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types
//and descriptive names.


using System;
class PrintBankData
{
    static void Main()
    {
        object firstName = "Bilbo";
        object middleName = "the Hobbit";
        object lastName = "Baggins";
        string allNames = firstName + " " + middleName + " " + lastName;
        int balance = 295264589;
        string bankName = "Central Cooperative Bank";
        long iBAN = 851205468656891459;
        uint card1 = 2756845453;
        uint card2 = 2756845454;
        uint card3 = 2756845455;

        Console.WriteLine("Name: {0}", allNames);
        Console.WriteLine("Available amount of money: {0} USD", balance);
        Console.WriteLine("Bank Name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iBAN);
        Console.WriteLine("Associated Credit Card Numbers: \n   1. {0} \n   2. {1} \n   3. {2}", card1, card2, card3);


    }
}