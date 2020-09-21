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
            VqlApi vqlApi = new VqlApi(configurationFile);

            string selectstatement = "SELECT * FROM clients()";
            var response = await vqlApi.Query(selectstatement);


        }
    }
}
