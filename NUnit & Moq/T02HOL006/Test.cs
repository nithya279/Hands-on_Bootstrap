using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using T02HOL006;

namespace T02HOL006
{
    [TestFixture]
    public class T02HOL006_Testing
    {
        T02HOL006 script = new T02HOL006();
        [Test]
        public void DividendAndDivisorIsNotZero()
        {
            var result = script.Divide(20, 4);
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void DiviorIsZero_()
        {
            Assert.Throws<DivideByZeroException>(() => script.Divide(20, 0));
        }
    }
}
