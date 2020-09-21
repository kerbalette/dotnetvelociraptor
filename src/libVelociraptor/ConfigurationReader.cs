using System;
using System.Collections.Generic;
using System.IO;
using libVelociraptor.Models;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace libVelociraptor
{
    public class ConfigurationReader
    {
        public ConfigurationReader(string configuration)
        {
            StreamReader input = new StreamReader(configuration);

            var deserializer = new DeserializerBuilder()
                .IgnoreUnmatchedProperties()
                .WithNamingConvention(UnderscoredNamingConvention.Instance).Build();

            //var deserializer = new Deserializer();
            Configuration = deserializer.Deserialize<Configuration>(input);
        }

        public Configuration Configuration { get; }
    }
}
