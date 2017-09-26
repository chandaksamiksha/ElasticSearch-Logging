using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageLog
{
    public class Input
    {
        public string packageName;
        public int packageVersion;
        public DateTime time;
        EsClient esClient = new EsClient();
       
        public Input(string packageName,int packageVersion)
        {
            this.packageName = packageName;
            this.packageVersion = packageVersion;
            time = DateTime.Now;
            StoreInput();
        }      
        public void StoreInput()
        {
            var packageDetails = new PackageDetails
            {
                Values =
            {
                    { "Name", packageName },{ "Version", packageVersion },{ "Time", time }
            }

            };

            esClient.Client.Index(packageDetails, i => i.Index("package-log"));
        }
    }
}
