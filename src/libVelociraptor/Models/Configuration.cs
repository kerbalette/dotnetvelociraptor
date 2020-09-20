using System;
using System.Collections.Generic;
using System.Text;
using Grpc.Core;

namespace libVelociraptor.Models
{
    public class Configuration
    {
        private string _ca_certificate;
        private string _client_cert;
        private string _client_private_key;
        private string _api_connection_string;
        private string _name;

        public string CaCertificate
        {
            get => _ca_certificate;
            set => _ca_certificate = value;
        }

        public string ClientCert
        {
            get => _client_cert;
            set => _client_cert = value;
        }

        public string ClientPrivateKey
        {
            get => _client_private_key;
            set => _client_private_key = value;
        }

        public string Target
        {
            get => _api_connection_string.Split(':')[0];
        }

        public int Port
        {
            get => int.Parse(_api_connection_string.Split(':')[1]);
        }

        public string ApiConnectionString
        {
            get => _api_connection_string;
            set => _api_connection_string = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public SslCredentials SslCredentials
        {
            get
            {
                KeyCertificatePair keyPair = new KeyCertificatePair(_client_cert, _client_private_key);
                SslCredentials sslCredentials = new SslCredentials(_ca_certificate, keyPair);
                return sslCredentials;
            }
        }
    }
}
