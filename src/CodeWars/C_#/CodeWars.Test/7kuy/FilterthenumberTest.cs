﻿using CodeWars.Lib;

namespace CodeWars.Test;

public class FilterthenumberTest
{
    [Test]
    public static void FixedTests()
    {
        Assert.AreEqual(123, Filterthenumber.FilterString("123"), "Just return the numbers");
        Assert.AreEqual(123, Filterthenumber.FilterString("a1b2c3"), "Just return the numbers");
        Assert.AreEqual(123, Filterthenumber.FilterString("aa1bb2cc3dd"), "Just return the numbers");
    }
}