using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ids.smtpreport
{
    public class PublicIpCheck : CheckBase
    {
        public PublicIpCheck()
        {
            Name = "Publiczny adres IP";
            hosts = new List<string>()
            {
                "http://ifconfig.me/",
                "http://checkip.dyndns.org/"
            };
        }

        private List<string> hosts;

        public bool TryGenerateCheck(out string answer)
        {
            answer = "";
            bool success = false;

            foreach (string host in hosts)
            {
                try
                {
                    answer += "Host: " + host + Environment.NewLine;
                    answer += PublicIpHelper.GetPublicIpAddress(host);
                    answer += Environment.NewLine;
                    success = true;       
                }
                catch (Exception ex)
                {
                    answer += ex.Message;
                }
            }
            return success;
        }
    }
}
