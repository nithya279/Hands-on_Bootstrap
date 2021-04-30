using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01HOL001
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Add_WhenTwoNumbersAreGreaterThanZero()
        {
            T01HOL001 hs = new T01HOL001();

            var result = hs.Add(6, 5);

            Assert.That(result, Is.EqualTo(11));
        }

        [Test]
        public void Add_WhenAtleastOneNumberIsLessThanZero()
        {
            T01HOL001 hs = new T01HOL001();

            var result = hs.Add(6, -23);

           // Assert.That(result, Is.EqualTo(0));

            Assert.Zero(result);
        }
    }
}
