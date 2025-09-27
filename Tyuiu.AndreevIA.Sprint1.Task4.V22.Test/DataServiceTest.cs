using Tyuiu.AndreevIA.Sprint1.Task4.V22.Lib;


namespace Tyuiu.AndreevIA.Sprint1.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 4;
            double wait = 0.028;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
