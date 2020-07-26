using System.Runtime.CompilerServices;
using BrewLib.Models;
using NUnit.Framework;

namespace BrewLib.Tests
{
    public class FermentableColorTests
    {
        private IColor _color = new Color();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EBCReturnsCorrectlyConvertedValue()
        {
            var srmValue = 2.3;
            var expectedEBC = 4.5;
            _color = new Color(srmValue);
            Assert.AreEqual(expectedEBC, _color.EBC);
        }

        [Test]
        public void EBCSetsCorrectSRM()
        {
            var expectedSRM = 2.3;
            var ebc = 4.5;
            _color.EBC = ebc;
            Assert.AreEqual(expectedSRM, _color.SRM);
        }

        [Test]
        public void LovibondReturnsCorrectlyConvertedValue()
        {
            var expectedLovibond = 7.9;
            var srm = 9.9;
            _color = new Color(srm);
            Assert.AreEqual(expectedLovibond, _color.Lovibond);
        }
        [Test]
        public void LovibondSetsCorrectSRM()
        {
            var lovibond = 7.9;
            var expectedSRM = 9.9;
            _color.Lovibond = lovibond;
            Assert.AreEqual(expectedSRM, _color.SRM);
        }
    }
}