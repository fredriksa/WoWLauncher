using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Launcher
{
    class URLFormatter
    {
        private static string httpPattern = @"http:\/\/";

        public static string format(string url)
        {
            if (!Regex.Match(url, httpPattern).Success)
                url = "http://" + url;

            return url;
        }
    }
}
