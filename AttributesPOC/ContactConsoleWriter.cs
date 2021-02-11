using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace AttributesPOC
{
    public class ContactConsoleWriter
    {
        private readonly Contact contact;
        private ConsoleColor color;

        public ContactConsoleWriter(Contact _contact)
        {
            contact = _contact;
        }
        //[Obsolete]
        //[Obsolete("You can't use it anymore",true)]//it's false by default
        public void WriteContact()
        {
            //PropertyInfo , Type => both inherits from member info
            /*
             * GetCustomAttribute=> it takes an element : class , property .... 
             * and the attribute you search for it
             * */
            var displayClassAttribute = (DisplayClassAttribute)Attribute.GetCustomAttribute(typeof(Contact),typeof(DisplayClassAttribute));

            var repeatedAttributes = (RepeatedAttribute[]) typeof(Contact).GetProperty(nameof(contact.FirstName)).GetCustomAttributes(typeof(RepeatedAttribute));
            var sb = "";
            if(repeatedAttributes.Length>0)
            {
                sb = $"RepeatedAttribute was repeated {repeatedAttributes.Length} times.";
            }
            Console.WriteLine(sb);
            SaveFroreColor();
            WriteFirstName();
            Console.ForegroundColor = displayClassAttribute.Color;
            WriteAge();
            RestoreForeColor();
            Console.WriteLine("The End");
        }

        internal void WriteFirstName()
        {
            //PropertyInfo , Type => both inherits from member info

            var propInfo = typeof(Contact).GetProperty(nameof(contact.FirstName));
            var displayAttribute = (DisplayAttribute) Attribute.GetCustomAttribute(propInfo,typeof(DisplayAttribute));
            var str = new StringBuilder();
            if(!String.IsNullOrWhiteSpace(displayAttribute.Label))
            {
                str.Append(displayAttribute.Label);
            }
            str.Append(contact.FirstName);
            Console.ForegroundColor = displayAttribute.Color;
            Console.WriteLine(str);
        }


        public void SaveFroreColor()
        {
            color = Console.ForegroundColor;
        }
        public void RestoreForeColor()
        {
            Console.ForegroundColor = color;
        }

        internal void WriteAge()
        {
            DebugModeMsg();
            Console.WriteLine(contact.Age);
        }
        [Conditional("DEBUG")]
        public void DebugModeMsg()
        {
            Console.WriteLine("*** Debug Mode ***");
        }

    }
}
