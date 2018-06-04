using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;

namespace JsonBenchmark
{
    class Program
    {
        public class AllowNonOptimized : ManualConfig
        {
            public AllowNonOptimized()
            {
                Add(JitOptimizationsValidator.DontFailOnError); // ALLOW NON-OPTIMIZED DLLS

                Add(DefaultConfig.Instance.GetLoggers().ToArray()); // manual config has no loggers by default
                Add(DefaultConfig.Instance.GetExporters().ToArray()); // manual config has no exporters by default
                Add(DefaultConfig.Instance.GetColumnProviders().ToArray()); // manual config has no columns by default
            }
        }
        
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<JsonDeserializersBenchmarks>(new AllowNonOptimized());
            BenchmarkRunner.Run<JsonSerializersBenchmarks>(new AllowNonOptimized());
        }
    }
}
