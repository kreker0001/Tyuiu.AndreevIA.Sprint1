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
            double x = 0;
            double y = 2;
            double wait = -1.681;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait,res);
        }
    }
}
