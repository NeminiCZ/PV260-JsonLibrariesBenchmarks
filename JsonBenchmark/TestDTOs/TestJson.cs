using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ZeroFormatter;

namespace JsonBenchmark.TestDTOs
{
    [ZeroFormattable]
    public class TestJson
    {
        [Index(0)]
        public virtual String _id { get; set; }
        [Index(1)]
        public virtual int index { get; set; }
        [Index(2)]
        public virtual String guid { get; set; }
        [Index(3)]
        public virtual bool isActive { get; set; }
        [Index(4)]
        public virtual String balance { get; set; }
        [Index(5)]
        public virtual String picture { get; set; }
        [Index(6)]
        public virtual int age { get; set; }
        [Index(7)]
        public virtual String eyeColor { get; set; }
        [Index(8)]
        public virtual String name { get; set; }
        [Index(9)]
        public virtual String gender { get; set; }
        [Index(10)]
        public virtual String company { get; set; }
        [Index(11)]
        public virtual String favoriteFruit { get; set; }
    }
    

}
