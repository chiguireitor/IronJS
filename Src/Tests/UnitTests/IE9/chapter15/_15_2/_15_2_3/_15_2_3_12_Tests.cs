// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter15._15_2._15_2_3
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _15_2_3_12_Tests : IE9TestFixture
    {
        public _15_2_3_12_Tests() : base(@"chapter15\15.2\15.2.3\15.2.3.12") { }

        [Test(Description = "Object.isFrozen must exist as a function")] public void _15_2_3_12__0__1() { RunFile(@"15.2.3.12-0-1.js"); }
        [Test(Description = "Object.isFrozen must exist as a function taking 1 parameter")] public void _15_2_3_12__0__2() { RunFile(@"15.2.3.12-0-2.js"); }
        [Test(Description = "Object.isFrozen throws TypeError if type of first param is not Object")] public void _15_2_3_12__1() { RunFile(@"15.2.3.12-1.js"); }
        [Test(Description = "Object.isFrozen - TypeError is thrown when the first param \'O\' is undefined")] public void _15_2_3_12__1__1() { RunFile(@"15.2.3.12-1-1.js"); }
        [Test(Description = "Object.isFrozen - TypeError is thrown when the first param \'O\' is null")] public void _15_2_3_12__1__2() { RunFile(@"15.2.3.12-1-2.js"); }
        [Test(Description = "Object.isFrozen - TypeError is thrown when the first param \'O\' is a boolean")] public void _15_2_3_12__1__3() { RunFile(@"15.2.3.12-1-3.js"); }
        [Test(Description = "Object.isFrozen - TypeError is thrown when the first param \'O\' is a string")] public void _15_2_3_12__1__4() { RunFile(@"15.2.3.12-1-4.js"); }
        [Test(Description = "Object.isFrozen applies to dense array")] public void _15_2_3_12__1__5() { RunFile(@"15.2.3.12-1-5.js"); }
        [Test(Description = "Object.isFrozen applies to sparse array")] public void _15_2_3_12__1__6() { RunFile(@"15.2.3.12-1-6.js"); }
        [Test(Description = "Object.isFrozen applies to non-array object which contains index named properties")] public void _15_2_3_12__1__7() { RunFile(@"15.2.3.12-1-7.js"); }
        [Test(Description = "Object.isFrozen - inherited data property is not considered into the for each loop")] public void _15_2_3_12__2__1() { RunFile(@"15.2.3.12-2-1.js"); }
        [Test(Description = "Object.isFrozen - inherited accessor property is not considered into the for each loop")] public void _15_2_3_12__2__2() { RunFile(@"15.2.3.12-2-2.js"); }
        [Test(Description = "Object.isFrozen - \'P\' is own data property")] public void _15_2_3_12__2__a__1() { RunFile(@"15.2.3.12-2-a-1.js"); }
        [Test(Description = "Object.isFrozen - \'O\' is the Arguments object")] public void _15_2_3_12__2__a__11() { RunFile(@"15.2.3.12-2-a-11.js"); }
        [Test(Description = "Object.isFrozen - \'O\' is a String object")] public void _15_2_3_12__2__a__12() { RunFile(@"15.2.3.12-2-a-12.js"); }
        [Test(Description = "Object.isFrozen - \'O\' is a Function object")] public void _15_2_3_12__2__a__13() { RunFile(@"15.2.3.12-2-a-13.js"); }
        [Test(Description = "Object.isFrozen - \'O\' is an Array object")] public void _15_2_3_12__2__a__14() { RunFile(@"15.2.3.12-2-a-14.js"); }
        [Test(Description = "Object.isFrozen - \'P\' is own data property that overrides an inherited data property")] public void _15_2_3_12__2__a__2() { RunFile(@"15.2.3.12-2-a-2.js"); }
        [Test(Description = "Object.isFrozen - \'P\' is own data property that overrides an inherited accessor property")] public void _15_2_3_12__2__a__3() { RunFile(@"15.2.3.12-2-a-3.js"); }
        [Test(Description = "Object.isFrozen - \'P\' is own accessor property")] public void _15_2_3_12__2__a__4() { RunFile(@"15.2.3.12-2-a-4.js"); }
        [Test(Description = "Object.isFrozen - \'P\' is own accessor property that overrides an inherited data property")] public void _15_2_3_12__2__a__5() { RunFile(@"15.2.3.12-2-a-5.js"); }
        [Test(Description = "Object.isFrozen - \'P\' is own accessor property that overrides an inherited accessor property")] public void _15_2_3_12__2__a__6() { RunFile(@"15.2.3.12-2-a-6.js"); }
        [Test(Description = "Object.isFrozen - \'P\' is own accessor property without a get function")] public void _15_2_3_12__2__a__7() { RunFile(@"15.2.3.12-2-a-7.js"); }
        [Test(Description = "Object.isFrozen - \'P\' is own accessor property without a get function that overrides an inherited accessor property")] public void _15_2_3_12__2__a__8() { RunFile(@"15.2.3.12-2-a-8.js"); }
        [Test(Description = "Object.isFrozen returns false if \'O\' contains own writable data property")] public void _15_2_3_12__2__b__i__1() { RunFile(@"15.2.3.12-2-b-i-1.js"); }
        [Test(Description = "Object.isFrozen returns false if \'O\' contains own configurable data property")] public void _15_2_3_12__2__c__1() { RunFile(@"15.2.3.12-2-c-1.js"); }
        [Test(Description = "Object.isFrozen returns false if \'O\' contains own configurable accessor property")] public void _15_2_3_12__2__c__2() { RunFile(@"15.2.3.12-2-c-2.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Global)")] public void _15_2_3_12__3__1() { RunFile(@"15.2.3.12-3-1.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Boolean)")] public void _15_2_3_12__3__10() { RunFile(@"15.2.3.12-3-10.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Boolean.prototype)")] public void _15_2_3_12__3__11() { RunFile(@"15.2.3.12-3-11.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Number)")] public void _15_2_3_12__3__12() { RunFile(@"15.2.3.12-3-12.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Number.prototype)")] public void _15_2_3_12__3__13() { RunFile(@"15.2.3.12-3-13.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Math)")] public void _15_2_3_12__3__14() { RunFile(@"15.2.3.12-3-14.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Date)")] public void _15_2_3_12__3__15() { RunFile(@"15.2.3.12-3-15.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Date.prototype)")] public void _15_2_3_12__3__16() { RunFile(@"15.2.3.12-3-16.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (RegExp)")] public void _15_2_3_12__3__17() { RunFile(@"15.2.3.12-3-17.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (RegExp.prototype)")] public void _15_2_3_12__3__18() { RunFile(@"15.2.3.12-3-18.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Error)")] public void _15_2_3_12__3__19() { RunFile(@"15.2.3.12-3-19.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Object)")] public void _15_2_3_12__3__2() { RunFile(@"15.2.3.12-3-2.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Error.prototype)")] public void _15_2_3_12__3__20() { RunFile(@"15.2.3.12-3-20.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (EvalError)")] public void _15_2_3_12__3__21() { RunFile(@"15.2.3.12-3-21.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (RangeError)")] public void _15_2_3_12__3__22() { RunFile(@"15.2.3.12-3-22.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (ReferenceError)")] public void _15_2_3_12__3__23() { RunFile(@"15.2.3.12-3-23.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (SyntaxError)")] public void _15_2_3_12__3__24() { RunFile(@"15.2.3.12-3-24.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (TypeError)")] public void _15_2_3_12__3__25() { RunFile(@"15.2.3.12-3-25.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (URIError)")] public void _15_2_3_12__3__26() { RunFile(@"15.2.3.12-3-26.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (JSON)")] public void _15_2_3_12__3__27() { RunFile(@"15.2.3.12-3-27.js"); }
        [Test(Description = "Object.isFrozen returns true when all own properties of \'O\' are not writable and not configurable, and \'O\' is not extensible")] public void _15_2_3_12__3__28() { RunFile(@"15.2.3.12-3-28.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Object.prototype)")] public void _15_2_3_12__3__3() { RunFile(@"15.2.3.12-3-3.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Function)")] public void _15_2_3_12__3__4() { RunFile(@"15.2.3.12-3-4.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Function.prototype)")] public void _15_2_3_12__3__5() { RunFile(@"15.2.3.12-3-5.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Array)")] public void _15_2_3_12__3__6() { RunFile(@"15.2.3.12-3-6.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (Array.prototype)")] public void _15_2_3_12__3__7() { RunFile(@"15.2.3.12-3-7.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (String)")] public void _15_2_3_12__3__8() { RunFile(@"15.2.3.12-3-8.js"); }
        [Test(Description = "Object.isFrozen returns false for all built-in objects (String.prototype)")] public void _15_2_3_12__3__9() { RunFile(@"15.2.3.12-3-9.js"); }
        [Test(Description = "Object.isFrozen returns false if extensible is true")] public void _15_2_3_12__4__1() { RunFile(@"15.2.3.12-4-1.js"); }
    }
}