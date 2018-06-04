using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Code;
using fastJSON;
using JsonBenchmark.TestDTOs;
using Newtonsoft.Json;
using ZeroFormatter;

namespace JsonBenchmark
{
    [ClrJob(isBaseline: true)]
    [RPlotExporter, RankColumn]
    [HtmlExporter]
    public class JsonSerializersBenchmarks : JsonBenchmarkBase
    {
        [Benchmark]
        public String NewtonsoftJson_Serialize()
        {
            return JsonConvert.SerializeObject(JsonSample);
        }

        [Benchmark]
        public String FastJson_Serialize()
        {
            return JSON.ToJSON(JsonSample);
        }

        [Benchmark]
        public byte[] ZeroFormatter_Serialize()
        {
            return ZeroFormatterSerializer.Serialize<Root2>(JsonSample);
        }
    }
    
}
