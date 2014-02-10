using System;

namespace ids.smtpreport
{
    [Serializable]
    public class GeneralEntity : IEntity
    {
        public string InstanceName { get; set; }

        public bool Enabled { get; set; }

        public int MinuteDelay { get; set; }
    }
}
