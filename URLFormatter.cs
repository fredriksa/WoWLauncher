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
        private static string wwwPattern = "www";
        private static string setRealmlistPattern = @"set\srealmlist\s";

        public static string format(string url)
        {
            if (!Regex.Match(url, httpPattern).Success)
                url = "http://" + url;

            return url;
        }

        public static string formatPingUrl(string url)
        {
            if (Regex.Match(url, httpPattern).Success)
               url = Regex.Replace(url, httpPattern, "");

            if (Regex.Match(url, wwwPattern).Success)
               url = Regex.Replace(url, wwwPattern, "");

            if (Regex.Match(url, setRealmlistPattern).Success)
               url = Regex.Replace(url, setRealmlistPattern, "");

            return url;
        }
    }
}
