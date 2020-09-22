using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using libVelociraptor;
using libVelociraptor.Models;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;
using YamlDotNet.Serialization;


namespace testsVelociraptor
{
    public class VqlApiTests
    {
        private readonly ITestOutputHelper output;

        public VqlApiTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public async void Query_Test()
        {
            var configurationFile = @"api.config.yaml";
            VqlApi vqlApi = new VqlApi(configurationFile);

            string selectstatement = "SELECT * FROM clients()";
            var response = await vqlApi.Query(selectstatement);

            dynamic records = JsonConvert.DeserializeObject(response);
            OutputFormatter result = new OutputFormatter(records);
            StringWriter writer = result.Output();
            output.WriteLine(writer.ToString());


        }
    }
}
