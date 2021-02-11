using System;

namespace AttributesPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact { FirstName="Sara", Age=24 };
            var contactConsoleWriter = new ContactConsoleWriter(contact);
            contactConsoleWriter.WriteContact();
            Console.WriteLine("Hello World!");
        }
    }
}
