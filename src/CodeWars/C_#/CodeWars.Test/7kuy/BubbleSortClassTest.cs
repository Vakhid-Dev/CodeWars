public class BubbleSortClassTest
{
 
    [Test]
    public static void SwappedTest()
    {
     // Arrange 
     BubbleSortClass sort =  new BubbleSortClass();
     int a = 10;
     int b = 2;

     // Act
  
     sort.Swap(ref a, ref b);
     
     //Assert
     Assert.AreEqual(a, 2);
     Assert.AreEqual(b, 10);
    }


    [Test]
    public static void BubbleSortTest()
    {
     // Arrange 
     var sort =  new BubbleSortClass();
     int [] arr = new int [] { 1, 2,4,5,61,0};

     // Act
     sort.BubbleSort(arr);
     
     //Assert
     Assert.AreEqual( new int [] { 0,1,2,4,5,61} , arr);
    }
}