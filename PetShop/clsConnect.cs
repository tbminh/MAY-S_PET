using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class clsConnect
    {
        static string svrdatabase = "PET_STORE_MANAGEMENT";
        static string sname = "192.168.32.82";
        static string svvrruser = "sa";
        static string svrpass = "123";
        //public static string Connect_String = $"Provider = SQLOLEDB;Data Source={sname};Initial Catalog={svrdatabase};User Id={svvrruser};Password={svrpass}";
        public static string Connect_String = "Provider=SQLOLEDB;Server=DESKTOP-4DPF4JC;Database=PET_STORE_MANAGEMENT;Trusted_Connection=yes;";
    }
}
