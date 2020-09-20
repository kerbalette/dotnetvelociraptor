using System;
using System.IO;
using libVelociraptor;
using libVelociraptor.Models;
using Xunit;


namespace testsVelociraptor
{
    public class VqlApiTests
    {
        [Fact]
        public async void Query_Test()
        {
            var configurationFile = @"api.config.yaml";
            string config = File.ReadAllText(configurationFile);

            ConfigurationReader configurationReader = new ConfigurationReader(configurationFile);
            Configuration configuration = configurationReader.Configuration;



            VqlApi vqlApi = new VqlApi(configurationReader.Configuration);
            string selectstatement = "SELECT * FROM clients()";
            var response = await vqlApi.Query(selectstatement);


        }
    }
}
