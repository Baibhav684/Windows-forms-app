using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WAMicroProject
{
    internal class GlobalData
    {
        public static string Username;
        public static double sum;
        public static DateTime BDT;
        public static DataSet DS1 = new DataSet();
        public static double serviceTax;
        public static double VAT;
        public static double Disco;
        public static double TotalBill;
    }
}
