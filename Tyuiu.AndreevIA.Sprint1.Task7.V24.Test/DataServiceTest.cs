using Tyuiu.AndreevIA.Sprint1.Task7.V24.Lib;

namespace Tyuiu.AndreevIA.Sprint1.Task7.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = -1.61;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait,res);
        }
    }
}
