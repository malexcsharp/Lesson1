using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family2020.Extentions
{
   public static class StringExtentions
    {
        public static string SayHello(this string name)
        {
            return $"Hello {name}.";
        }

        public static bool IsValidZip(this string zip)
        {
           
            return zip.Length == 5 && Int32.TryParse(zip, out int p) || zip.Length == 9 && Int32.TryParse(zip, out int n);
        }
    }
}
