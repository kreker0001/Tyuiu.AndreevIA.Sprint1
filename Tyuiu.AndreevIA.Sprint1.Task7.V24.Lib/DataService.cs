using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AndreevIA.Sprint1.Task7.V24.Lib
{
    public class DataService : ISprint1Task7V24
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Sqrt(1 + Math.Cos(x))) / (Math.Sin(1.5 * y - 4));
            return Math.Round(res,3);
        }
    }
}
