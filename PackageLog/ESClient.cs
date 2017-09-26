using Elasticsearch.Net;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageLog
{
    public class EsClient
    {
        public ElasticClient Client { get; set; }

        public EsClient()
        {
            var pool = new SingleNodeConnectionPool(new Uri("http://localhost:9200"));
            var connectionSettings = new ConnectionSettings(pool);
            Client = new ElasticClient(connectionSettings);
        }
    }
}
