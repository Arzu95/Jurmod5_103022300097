using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jurmod5_103022300097;

namespace Jurmod5_103022300097
{
    public class PemrosesData
    {
        public dynamic DapatkanNilaiTerbesar<T>(T x1, T x2, T x3)
        {
            dynamic bilangan1 = x1;
            dynamic bilangan2 = x2;
            dynamic bilangan3 = x3;

            if(bilangan1 > bilangan2)
            {
                return bilangan1;
            }
            else if (bilangan3 > bilangan2)
            {
                return bilangan2;
            }
            else
            {
                return bilangan3;
            }
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PemrosesData pemrosesData = new PemrosesData();
    //        Console.WriteLine(pemrosesData.DapatkanNilaiTerbesar<int>(10, 30, 22));
    //    }
    //}
}




