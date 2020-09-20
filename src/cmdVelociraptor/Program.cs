using System;
using System.Reflection;
using cmdVelociraptor.Models;
using CommandLine;

namespace cmdVelociraptor
{
    class Program
    {
        static void Main(string[] args)
        {
            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            var header = $"{assemblyName}, version {Assembly.GetExecutingAssembly().GetName().Version}";

            var cmdOptions = CommandLine.Parser.Default.ParseArguments<ApplicationArguments>(args)
                .WithParsed(RunOptions);
        }

        private static void RunOptions(ApplicationArguments applicationArguments)
        {
            Utils.AppConfiguration.LoadConfiguration(applicationArguments);
        }
    }
}
