using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using T02HOL001;

namespace T02HOL001
{

    [TestFixture]
    public class Test
    {
        T02HOL001 logicScript = new T02HOL001();
        [Test, Order(1)]
        public void Add()
        {
            var result = logicScript.Add(5, 10);
            Assert.That(result, Is.EqualTo(15));
        }
        [Test, Order(4)]
        public void Subtract()
        {
            var result = logicScript.Subtract(10, 5);
            Assert.That(result, Is.EqualTo(5));
        }
        [Test, Order(3)]
        public void Multiply()
        {
            var result = logicScript.Multiply(3, 5);
            Assert.That(result, Is.EqualTo(15));
        }
        [Test, Order(2)]
        [Ignore("Ignore divide")]
        public void Divide()
        {
            var result = logicScript.Divide(20, 5);
            Assert.That(result, Is.EqualTo(4));
        }
        [Test]
        [TestCaseSource(nameof(TestCaseValues))]
        public void Add_MultipleInputs_MultipleOutputs(double a, double b)
        {
            var result = logicScript.Add(a, b);
            Assert.That(result, Is.EqualTo(a + b));

        }
        static readonly object[] TestCaseValues =
        {
            new object[] {10,5},
            new object[] {3,8},
            new object[] {10,20}
        };

    }
}
