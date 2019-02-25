using Microsoft.VisualStudio.TestTools.UnitTesting;
using Billetlibary;
namespace untitestmc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
           MC mc = new MC();
            // act 
            decimal Pris = mc.Pris();
            // assert 
            Assert.AreEqual(125, Pris);

        }
        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            MC mc = new MC();
            // act
            string køretøj = mc.KøreTøj();
            // Assert
            Assert.AreEqual("MC", køretøj);
        }
    }
}
