using System;
namespace Play_Code
{
    public class Horners_Rule
    {
        public static int GeoSeriesSum(int x, int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++) {sum = sum * x + 1;}
            return sum;
        }
    }
}
