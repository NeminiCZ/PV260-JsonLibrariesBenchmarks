using System;
using System.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using fastJSON;
using JsonBenchmark.TestDTOs;
using Newtonsoft.Json;
using ZeroFormatter;

namespace JsonBenchmark
{
    [ClrJob(isBaseline: true)]
    [RPlotExporter, RankColumn]
    [HtmlExporter]
    public class JsonDeserializersBenchmarks : JsonBenchmarkBase
    {
        [Benchmark]
        public Root2 NewtonsoftJson_Deserialize()
        {
            return JsonConvert.DeserializeObject<Root2>(JsonSampleString2);
        }

        [Benchmark]
        public Root2 NewtonsoftJson_DeserializeStream()
        {
            using (StreamReader sr = new StreamReader(Path.Combine(AppContext.BaseDirectory, TestFilesFolder, "testingJson.json")))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                JsonSerializer serializer = new JsonSerializer();
                return serializer.Deserialize<Root2>(reader);
            }

        }

        [Benchmark]
        public Root2 FastJson_Deserialize()
        {
            return JSON.ToObject<Root2>(JsonSampleString2);

        }


        [Benchmark]
        public Root2 ZeroFormatter_Deserialize()
        {
            return ZeroFormatterSerializer.Deserialize<Root2>(ZeroFormatterSampleString2);
        }
    }
}
