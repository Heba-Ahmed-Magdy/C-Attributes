using System;

namespace AttributesPOC
{
    //AllowMultiple=> default value is false
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]
    public class RepeatedAttribute : Attribute
    {
    }
}