using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{   
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestName() // indico que voy a realizar testeo de un nombre
        {
            Person joaquin = new Person("Joaquin", "5.285.723-3");
            string expected = "Joaquin"; // indico que el valor esperado es el siguiente
            Assert.AreEqual(expected, joaquin.Name);
        }

        [Test]
        public void TestID() // indico que voy a realizar testeo de una ID
        {
            Person joaquin = new Person("Joaquin", "5.285.723-3");
            string expected = "5.285.723-3"; // indico que el valor esperado es el siguiente
            Assert.AreEqual(expected, joaquin.ID);
        }
    

    }
}