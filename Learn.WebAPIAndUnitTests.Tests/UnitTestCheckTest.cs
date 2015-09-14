using NSubstitute;
using NUnit.Framework;

namespace Learn.WebAPIAndUnitTests.Tests
{
    [TestFixture]
    class UnitTestCheckTest
    {
        [Test]
        public void TestTesterTest()
        {
            var iMockCheckerMock = Substitute.For<IMockChecker>();
            iMockCheckerMock.GetAppendedText("1").Returns("12");

            UnitTestCheck check = new UnitTestCheck();
            Assert.AreEqual(check.TestCaseChecker(iMockCheckerMock), "123");
        }
    }
}
