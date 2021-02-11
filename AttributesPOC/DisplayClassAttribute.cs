using System;

namespace AttributesPOC
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DisplayClassAttribute : Attribute
    {
        public DisplayClassAttribute(ConsoleColor _color)
        {
            Color = _color;
        }
        public ConsoleColor Color { get; }
    }
}