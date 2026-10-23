using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopping.Services
{
    public static class DinhDang
    {
        public static readonly CultureInfo VN = new CultureInfo("vi-VN");
        public static string Tien(decimal so) { return so.ToString("N0", VN); }
    }
}
