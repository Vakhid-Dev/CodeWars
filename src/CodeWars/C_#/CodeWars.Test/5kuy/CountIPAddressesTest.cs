using CodeWars.Lib._5kuy;

namespace CodeWars.Test._5kuy;

public class CountIPAddressesTest
{
    [Test]
    public void SmapleTest()
    {
        Assert.AreEqual(50, CountIPAddresses.IpsBetween("10.0.0.0", "10.0.0.50"));
        Assert.AreEqual(246, CountIPAddresses.IpsBetween("20.0.0.10", "20.0.1.0"));
        Assert.AreEqual((1L << 32) - 1L, CountIPAddresses.IpsBetween("0.0.0.0", "255.255.255.255"));
        Assert.AreEqual(15093905, CountIPAddresses.IpsBetween("151.103.6.45", "152.77.86.190"));

    }
}