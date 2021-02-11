using System;

namespace AttributesPOC
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayAttribute : Attribute
    {
        public DisplayAttribute(string _label,ConsoleColor _color=ConsoleColor.White)
        {
            Label = _label;
        }
        public string Label { get; set; }
        public ConsoleColor Color { get; set; }
    }
}