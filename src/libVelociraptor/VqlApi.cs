using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Grpc.Core.Utils;
using Proto;
using libVelociraptor.Models;

namespace libVelociraptor
{
    public class VqlApi
    {
        private readonly Configuration _configuration;
        private readonly Channel _channel;

        public VqlApi(Configuration configuration)
        {
            _configuration = configuration;
            var options = SetupChannelOption("VelociraptorServer");
            _channel = new Channel(_configuration.Target, _configuration.Port, _configuration.SslCredentials, options);
        }

        public async Task<string> Query(string query)
        {
            VQLCollectorArgs vqlCollectorArgs = new VQLCollectorArgs
            {
                MaxWait = 1,
                MaxRow = 100,
                Query = { new VQLRequest { Name = _configuration.Name, VQL = query } }
            };

            var apiClient = new API.APIClient(_channel);
            var streamResult = apiClient.Query(vqlCollectorArgs);
            var resultElement = await streamResult.ResponseStream.ToListAsync();
            _channel.ShutdownAsync().Wait();

            return resultElement[resultElement.Count - 1].Response;
        }

        private List<ChannelOption> SetupChannelOption(string targetNameOverride)
        {
            var options = new List<ChannelOption>
            {
                new ChannelOption(ChannelOptions.SslTargetNameOverride, targetNameOverride)
            };
            return options;
        }
    }
}
