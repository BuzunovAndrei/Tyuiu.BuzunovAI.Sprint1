using Tyuiu.BuzunovAI.Sprint1.Taks2.V18.Lib;
namespace Tyuiu.BuzunovAI.Sprint1.Taks2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 2;
            int valueTwo = 3;
            int valueThree = 4;
            var res = ds.CalculateSideSquareParallelepiped(value,valueTwo,valueThree);
            Assert.AreEqual(40,res);
        }
    }
}
