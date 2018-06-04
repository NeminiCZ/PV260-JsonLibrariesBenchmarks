using System;
using System.IO;
using JsonBenchmark.TestDTOs;
using Newtonsoft.Json;
using ZeroFormatter;

namespace JsonBenchmark
{
    public abstract class JsonBenchmarkBase
    {
        protected const string TestFilesFolder = "TestFiles";
        protected string JsonSampleString;
        protected string JsonSampleString2;
        protected Root RootSample;
        protected Root2 JsonSample;
        protected byte[] ZeroFormatterSampleString2;

        protected JsonBenchmarkBase()
        {
            JsonSampleString = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, TestFilesFolder, "chucknorris.json"));
            RootSample = JsonConvert.DeserializeObject<Root>(JsonSampleString);
            JsonSampleString2 = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, TestFilesFolder, "testingJson.json"));
            JsonSample = JsonConvert.DeserializeObject<Root2>(JsonSampleString2);
            ZeroFormatterSampleString2 = ZeroFormatterSerializer.Serialize<Root2>(JsonSample);
        }
    }
}
