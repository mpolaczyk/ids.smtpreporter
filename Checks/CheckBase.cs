using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ids.smtpreport
{
    public abstract class CheckBase
    {
        public string Name { get; set; }

        public virtual bool TryGenerateCheck(out string report)
        {
            report = "";
            return false;
        }
    }
}
