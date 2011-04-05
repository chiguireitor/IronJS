// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.DateObjects.PropertiesOfTheDatePrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class DatePrototypeGetUTCDateTests : SputnikTestFixture
    {
        public DatePrototypeGetUTCDateTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.9_Date_Objects\15.9.5_Properties_of_the_Date_Prototype_Object\15.9.5.15_Date.prototype.getUTCDate")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.15")]
        [TestCase("S15.9.5.15_A1_T1.js", Description = "The Date.prototype property \"getUTCDate\" has { DontEnum } attributes")]
        [TestCase("S15.9.5.15_A1_T2.js", Description = "The Date.prototype property \"getUTCDate\" has { DontEnum } attributes")]
        [TestCase("S15.9.5.15_A1_T3.js", Description = "The Date.prototype property \"getUTCDate\" has { DontEnum } attributes")]
        public void TheDatePrototypePropertyGetUTCDateHasDontEnumAttributes(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.15")]
        [TestCase("S15.9.5.15_A2_T1.js", Description = "The \"length\" property of the \"getUTCDate\" is 0")]
        public void TheLengthPropertyOfTheGetUTCDateIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.15")]
        [TestCase("S15.9.5.15_A3_T1.js", Description = "The Date.prototype.getUTCDate property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.5.15_A3_T2.js", Description = "The Date.prototype.getUTCDate property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.5.15_A3_T3.js", Description = "The Date.prototype.getUTCDate property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        public void TheDatePrototypeGetUTCDatePropertyLengthHasReadOnlyDontDeleteDontEnumAttributes(string file)
        {
            RunFile(file);
        }
    }
}