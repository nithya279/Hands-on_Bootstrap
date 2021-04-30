using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using T02HOL004;

namespace T02HOL004
{
    [TestFixture]
    public class UnitTest1
    {
        T02HOL004 script = new T02HOL004();
        [Test]
        [TestCaseSource(nameof(TestCaseValues))]
        public void CheckLeapYears(int year, int output)
        {
            var result = script.LeapYearCalculatorLib(year);
            Assert.That(result, Is.EqualTo(output));
        }
        static readonly object[] TestCaseValues =
        {
            new object[] {1638,-1},
            new object[] {2028,1},
            new object[] {2007,0},
            new object[] {10000,-1}
        };
    }
}
