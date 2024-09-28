using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KiselevEA.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            int res  = Convert.ToInt32(f / 30);
            return res;
        }
    }
}
