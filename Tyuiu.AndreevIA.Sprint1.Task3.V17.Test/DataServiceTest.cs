using Tyuiu.AndreevIA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.AndreevIA.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 123.456;
            bool wait = false;
            var res = ds.ZeroCheck(x);
            Assert.AreEqual(wait, res);
        }
    }
}
