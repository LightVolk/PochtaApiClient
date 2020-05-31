using System;
using System.Collections.Generic;
using System.Text;

namespace PochtaApiClient
{
    public class OperationHistoryResponce
    {
        public IEnumerable<OperationHistoryRecord> OperationHistoryRecords { get; set; }
    }
}
