using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    record TimeZone
    {
        public string ZoneName { get; init; }
        public int Diff { get; init; }
    }
}
