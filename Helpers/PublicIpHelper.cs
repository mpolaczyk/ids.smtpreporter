using System;
using System.IO;
using System.Net;

namespace ids.smtpreport
{
    public static class PublicIpHelper
    {
        public static string GetPublicIpAddress(string host)
        {
            if (string.IsNullOrEmpty(host)) { return string.Empty; };

            GC.Collect(0, GCCollectionMode.Forced);

            var request = (HttpWebRequest)WebRequest.Create(host);

            request.UserAgent = "curl";
            request.Method = "GET";

            string responseText;
            WebResponse response = null;

            try
            {
                using (response = request.GetResponse())
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseText = reader.ReadToEnd();
                    }   
                }
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }

            return responseText.Replace("\n", "");
        }
    }
}
