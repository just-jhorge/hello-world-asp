using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is a writeline method");
            //Console.WriteLine("This is another writeline Method");
            //Console.Write("This is a write method");
            //Console.Write("This is another write method");

            // COMMENTS
            // Use '//' for single line comments
            // Use '/* */' for multi line comments

            // VARIABLES - they can be changed, they can be declared without a value
            string role;
            int age = 30;
            bool isActive = true;
            double accountBalance = 125770.59;

            // CONSTANT VARIABLES - they cannot be changed
            const string NAME = "Kwadwo Sarpong";
            const char SEX = 'M';
            const bool IS_DEVELOPER = true;
            const string DESIGNATION = "Chief Technical Office";

            Console.WriteLine(NAME + " is a " + SEX + " working as the " + DESIGNATION + " of Hubtel Inc. He is " + age + " years of age and has a bank account balance of " + accountBalance + ".");
        }
    }
}