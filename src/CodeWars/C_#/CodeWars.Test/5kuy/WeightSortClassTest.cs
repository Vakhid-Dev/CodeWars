using CodeWars.Lib._5kuy;

namespace CodeWars.Test._5kuy;

public class WeightSortClassTest
{
    [Test]
    public void Test1() {
        Console.WriteLine("****** Basic Tests");    
        // Assert.AreEqual("54 351108 61724 166602 191019 341166 403950 115690 376303", WeightSortClass.orderWeight("54 351108 61724 191019 166602 341166 403950 115690 376303"));
        // Assert.AreEqual("2000 103 123 4444 99", WeightSortClass.orderWeight("103 123 4444 99 2000"));
     //  Assert.AreEqual("100 180 90 56 65 74 68 86 99", WeightSortClass.orderWeight("56 65 74 100 99 68 86 180 90"));
      // Assert.AreEqual("11 11 2000 10003 22 123 1234000 44444444 9999", WeightSortClass.orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
    }
    
    [Test]
    public void Test2() {
        Console.WriteLine("****** Basic Tests");    
     //   Assert.AreEqual("2000 103 123 4444 99", WeightSortClass.orderWeight("103 123 4444 99 2000"));
       Assert.AreEqual("11 11 2000 10003 22 123 1234000 44444444 9999", WeightSortClass.orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
    }
}