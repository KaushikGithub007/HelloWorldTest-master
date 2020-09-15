using NUnit.Framework;
using HelloWorldTest;
using System.Buffers;

namespace HelloWorld_UnitTest
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
            Day obj = new Day();
           string result= obj.TodayIs(1);
            string expectedresult = "Mon";
            Assert.AreEqual(expectedresult, result);
        }
        public void Test2()
        {
            Day obj = new Day();
            string result = obj.TodayIs(1);
            string expectedresult = "Tues";
            Assert.AreEqual(expectedresult, result);
        }
        public void Test3()
        {
            Day obj = new Day();
            string result = obj.TodayIs(1);
            string expectedresult = "Wed";
            Assert.AreEqual(expectedresult, result);
        }
    }
}