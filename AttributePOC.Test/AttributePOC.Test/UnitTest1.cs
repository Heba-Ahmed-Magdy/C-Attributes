using AttributesPOC;
using NUnit.Framework;

namespace AttributePOC.Test
{
    public class Tests
    {
        private ContactConsoleWriter writer;

        [SetUp]
        public void Setup()
        {
            writer = new ContactConsoleWriter(new Contact {  FirstName="Heba", Age=25});
        }

        [Test]
        public void Test1()
        {
            writer.WriteAge();
            //Assert.Pass();
        }
    }
}