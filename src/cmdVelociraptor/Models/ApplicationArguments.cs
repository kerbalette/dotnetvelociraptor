using System;
using System.Collections.Generic;
using System.Text;
using CommandLine;

namespace cmdVelociraptor.Models
{
    public class ApplicationArguments
    {
        [Option('c', "config", Required = false, HelpText = "Velociraptor API Configuration File")]
        public string APIConfiguration { get; set; }

        [Option('q', "query", Required = true, HelpText = "VQL Command to execute")]
        public string Query { get; set; }
    }
}
