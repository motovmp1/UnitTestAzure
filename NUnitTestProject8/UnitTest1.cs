using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace NUnitTestProject8
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Setup()
        {
            System.Console.WriteLine("first step");
        }


        [TestMethod]
        public void Test1()
        {
           
            System.Console.WriteLine("Test1 step inside");

           
        }

        [TestMethod]
        public void Test2()
        {
            
            System.Console.WriteLine("Test2 step inside");

           
            System.Console.WriteLine("Pass");
        }
        [TestMethod]
        public void Test3()
        {

            System.Console.WriteLine("Test3 step inside");
            System.Console.WriteLine("Fail");
        }

        [TestMethod]
        public void Test6()
        {

            System.Console.WriteLine("Test6 step inside");
            System.Console.WriteLine("Fail");
        }
    }
}