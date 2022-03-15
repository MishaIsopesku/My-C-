using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(NumbReverseNet50.NumbReverse.Reverse(123), 321);
            Assert.AreEqual(NumbReverseNet50.NumbReverse.Reverse(567), 765);
            Assert.AreEqual(NumbReverseNet50.NumbReverse.Reverse(321), 123);

        }
    }
}
