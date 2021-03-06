// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.RegExpObjects
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PatternsTests : SputnikTestFixture
    {
        public PatternsTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.10_RegExp_Objects\15.10.1_Patterns")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.1")]
        [TestCase("S15.10.1_A1_T1.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T10.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T11.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T12.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T13.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T14.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T15.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T16.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T2.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T3.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T4.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T5.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T6.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T7.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T8.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        [TestCase("S15.10.1_A1_T9.js", Description = "RegExp syntax errors must be caught when matcher(s) compiles")]
        public void RegExpSyntaxErrorsMustBeCaughtWhenMatcherSCompiles(string file)
        {
            RunFile(file);
        }
    }
}