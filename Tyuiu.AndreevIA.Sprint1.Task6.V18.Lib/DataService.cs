using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AndreevIA.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            if (value.Length > 0 && !"123456789".Contains(value[0])) return false;


            for (int i = 1; i < value.Length; i++)
            {
                if (!"0123456789".Contains(value[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
