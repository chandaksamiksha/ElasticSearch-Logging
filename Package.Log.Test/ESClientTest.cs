using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackageLog;
using Nest;

namespace Package.Log.Test
{
    [TestClass]
    public class EsClientTest
    {
        [TestMethod]
        public void Check_If_Client_Is_Not_Null()
        {
            EsClient esClient = new EsClient();
            var client = esClient.Client;
            Assert.IsNotNull(client);
        }
    }
}
