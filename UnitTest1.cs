using System;
using CalcClassBr;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest { 
[TestClass]
public class IABSTests
{
        
    [TestMethod]
    public void IABS_PositiveNumber_ReturnsNegative()
    {
        long a = 123;
        long expected = -123;

        int result = CalcClass.IABS(a);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void IABS_NegativeNumber_ReturnsPositive()
    {
        long a = -456;
        long expected = 456;

        long result = CalcClass.IABS(a);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void IABS_Zero_ReturnsZero()
    {
        long a = 0;
        long expected = 0;

        long result = CalcClass.IABS(a);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void IABS_ValueExceedsIntRange_ThrowsException()
    {
        long a = (long)int.MaxValue + 1;

        CalcClass.IABS(a);
    }

       
    }



}