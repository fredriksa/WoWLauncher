using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Launcher
{
    class ResourceHelper
    {
        public static bool resourceExists(string url)
        {
            HttpWebResponse response = null;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "HEAD";

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                return false;
            }
            finally
            {
                if (response != null)
                    response.Close();
            }

            return true;
        }
    }
}
