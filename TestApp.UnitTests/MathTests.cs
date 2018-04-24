using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Fundamentals;


namespace TestApp.UnitTests
{
    [TestFixture]
    class MathTests
    {
        //SetUp  //TearDown (integration test mostly)

        private Fundamentals.Math _math;

        [SetUp]
        public void SetUp()
        {
             _math = new Fundamentals.Math();
        }

        [Test]
        //[Ignore("Just temporally")]
        public void Add_WhenCalled_ReturnSumOfArgs()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnGreaterFirstArg(int a, int b, int expectedResult)
        {         
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbers()
        {
            var result = _math.GetOddNumbers(5);

            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));
            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);
            
            Assert.That(result, Is.EqualTo(new[] { 1, 3, 5}));
        }
    }
}
