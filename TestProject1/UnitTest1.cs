using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NumberToWordWordToNumber;
using NumberToWordWordToNumber_Probando_paquete_nuget_;
using NumberToWors_WordToNumber;
using System.Runtime.Intrinsics.X86;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            converted convert = new converted();

            INPUT NEW1 = new INPUT(1);
            INPUT NEW2 = new INPUT("one dollars");
            OUTPUT exit1 = new OUTPUT(convert.convertn(NEW1));
            OUTPUT exit2 = new OUTPUT(convert.convertw(NEW2));

            Assert.AreEqual("one dollars", exit1.GetResult());
            Assert.AreEqual(1, exit2.GetResult());



            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            converted convert = new converted();

            INPUT NEW1 = new INPUT(100);
            INPUT NEW2 = new INPUT("one hundred dollars");
            OUTPUT exit1 = new OUTPUT(convert.convertn(NEW1));
            OUTPUT exit2 = new OUTPUT(convert.convertw(NEW2));

            Assert.AreEqual("one hundred dollars", exit1.GetResult());
            Assert.AreEqual(100, exit2.GetResult());

            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            converted convert = new converted();

            INPUT NEW1 = new INPUT(1999999999);
            INPUT NEW2 = new INPUT("forty sdfefwdwq dollars");
            OUTPUT exit1 = new OUTPUT(convert.convertn(NEW1));
            OUTPUT exit2 = new OUTPUT(convert.convertw(NEW2));

            Assert.AreEqual("Invalid input", exit1.GetResult());
            Assert.AreEqual("Invalid input", exit2.GetResult());

            Assert.Pass();
        }
    }
}