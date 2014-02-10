using System;

namespace ids.smtpreport
{
    [Serializable]
    public class SmtpEntity : IEntity
    {
        public string Host { get; set; }

        public int Port { get; set; }

        public string User { get; set; }

        public string Pass { get; set; }

        public string Receiver { get; set; }

    }
}
