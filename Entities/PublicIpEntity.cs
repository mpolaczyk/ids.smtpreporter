using System;

namespace ids.smtpreport
{
    [Serializable]
    class PublicIpEntity : IEntity
    {
        public DateTime LastReportTime { get; set; }

        public string LastReport { get; set; }
    }
}
