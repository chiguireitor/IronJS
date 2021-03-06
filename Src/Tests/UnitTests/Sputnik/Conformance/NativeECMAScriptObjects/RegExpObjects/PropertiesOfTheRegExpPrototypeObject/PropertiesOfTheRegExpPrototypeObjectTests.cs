// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.RegExpObjects.PropertiesOfTheRegExpPrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PropertiesOfTheRegExpPrototypeObjectTests : SputnikTestFixture
    {
        public PropertiesOfTheRegExpPrototypeObjectTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.10_RegExp_Objects\15.10.6_Properties_of_the_RegExp_Prototype_Object")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.6.1")]
        [TestCase("S15.10.6.1_A1_T1.js", Description = "The initial value of RegExp.prototype.constructor is the built-in RegExp constructor")]
        [TestCase("S15.10.6.1_A1_T2.js", Description = "The initial value of RegExp.prototype.constructor is the built-in RegExp constructor")]
        public void TheInitialValueOfRegExpPrototypeConstructorIsTheBuiltInRegExpConstructor(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.6")]
        [TestCase("S15.10.6_A1_T1.js", Description = "The value of the internal [[Prototype]] property of the RegExp prototype object is the Object prototype")]
        [TestCase("S15.10.6_A1_T2.js", Description = "The value of the internal [[Prototype]] property of the RegExp prototype object is the Object prototype")]
        public void TheValueOfTheInternalPrototypePropertyOfTheRegExpPrototypeObjectIsTheObjectPrototype(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.6")]
        [TestCase("S15.10.6_A2.js", Description = "The value of the internal [[Class]] property of the RegExp prototype object is \"Object\"")]
        public void TheValueOfTheInternalClassPropertyOfTheRegExpPrototypeObjectIsObject(string file)
        {
            RunFile(file);
        }
    }
}