﻿using Tyuiu.AndreevIA.Sprint1.Task0.V10.Lib;

namespace Tyuiu.AndreevIA.Sprint1.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(-10.5, res);

        }
    }
}
