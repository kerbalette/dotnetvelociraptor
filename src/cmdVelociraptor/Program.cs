using System;
using System.IO;
using System.Reflection;
using cmdVelociraptor.Models;
using CommandLine;
using libVelociraptor;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace cmdVelociraptor
{
    class Program
    {
        static async Task Main(string[] args)
        {

            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            var header = $"{assemblyName}, version {Assembly.GetExecutingAssembly().GetName().Version}";

            var cmdOptions = await CommandLine.Parser.Default.ParseArguments<ApplicationArguments>(args)
                .WithParsedAsync(RunOptions);

            //var cmdOptions = CommandLine.Parser.Default.ParseArguments<ApplicationArguments>(args)
            //    .WithParsed(options => RunOptions(options).Wait());
        }

        private static async Task RunOptions(ApplicationArguments applicationArguments)
        {
            Utils.AppConfiguration.LoadConfiguration(applicationArguments);
            VqlApi vqlApi = new VqlApi(applicationArguments.APIConfiguration);
            var output = await vqlApi.Query(applicationArguments.Query);

            dynamic records = JsonConvert.DeserializeObject(output);
            OutputFormatter result = new OutputFormatter(records);
            StringWriter writer = result.Output();
            Console.WriteLine(writer.ToString());
        }
    }
}
