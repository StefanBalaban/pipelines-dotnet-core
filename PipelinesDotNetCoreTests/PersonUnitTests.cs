using NUnit.Framework;
using pipelines_dotnet_core.Models;

namespace PipelinesTests
{
    [TestFixture]
    class PersonUnitTests
    {
        [Test]
        public void IntroduceTo_CalledWithJohnAndSmith_ContainsJohnAndSmith()
        {
            var person = new Person();
            person.Name = "John";

            var result = person.IntroduceTo("Smith");


            Assert.That(result, Does.Contain("John").IgnoreCase);
            Assert.That(result, Does.Contain("Smith").IgnoreCase);
        }
    }
}
