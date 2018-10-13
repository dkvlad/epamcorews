using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.CoreWorkshop.ReportHelper
{
    public static class ArrayHelper
    {
        public static void Fill<T>(T[] array, T value)
        {
#if NETCOREAPP2_0 || NETCOREAPP2_1
            Array.Fill<T>(array, value);
#else
            for (var i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                array[i] = value;
            }
#endif
            

        }
    }
}
