using System.Diagnostics;

namespace AttributesPOC
{
    [DebuggerDisplay("FName= {FirstName} && LName= {Age}")] 
    [DisplayClass(System.ConsoleColor.DarkRed)]
    public class Contact
    {
        [Display("First Name Lable : ",Color =System.ConsoleColor.Cyan)]
        [Repeated]
        [Repeated]
        [Repeated]
        public string FirstName { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int Age { get; set; }
    }
}