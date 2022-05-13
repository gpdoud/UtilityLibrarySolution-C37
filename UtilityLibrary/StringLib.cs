using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLibrary {

    public static class StringLib {

        public static string Concat(string a, string b) {
            return a + b;
        }
        public static string UpperCase(string a) {
            return a.ToUpper();
        }
        public static string LowerCase(string a) {
            return a.ToLower();
        }
        public static string TitleCase(string a) {
            return a[0].ToString().ToUpper() + a.Substring(1).ToLower();
        }

    }
}
