using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PochtaApiClient
{
    public class Client : IClient
    {
        private Config _config;

        public Client()
        {
            _config = new Config();
        }

        public Task<getOperationHistoryResponse> GetOperationHistory(string trackID)
        {
            OperationHistory12Client operationHistory12Client = new OperationHistory12Client(OperationHistory12Client.EndpointConfiguration.OperationHistory12Port);
            return operationHistory12Client.getOperationHistoryAsync(new OperationHistoryRequest()
            {
                Barcode = trackID,
                Language = "RUS",
                MessageType = 0
            }, _config.GetAuthorizationHeader());

        }
    }
}
