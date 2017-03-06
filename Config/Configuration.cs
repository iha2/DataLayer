using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using Couchbase;
using Couchbase.Configuration.Client;
using System.Collections.Generic;


namespace Configuration {

    public static class CouchbaseConfig {

        public static IConfigurationRoot Configuration { get; set; }
        
        public static IConfigurationRoot getConfig() {

                var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json");
                
                return builder.Build();
        }

        public static void Initialize() 
        {
            var config = getConfig();
            var couchbaseServer = config["Couchbase:server"];
            ClusterHelper.Initialize(new ClientConfiguration
            {
                Servers = new List<Uri> { new Uri(couchbaseServer) }
            });
        }

        public static void CleanUp()
        {
            ClusterHelper.Close();
        }
    }

}   