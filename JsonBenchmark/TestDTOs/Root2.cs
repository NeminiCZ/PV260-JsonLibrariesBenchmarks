using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFormatter;

namespace JsonBenchmark.TestDTOs
{


    [ZeroFormattable]
    public class Root2
    {
        [Index(0)]
        public virtual TestJson[] result { get; set; }
    }
}
