using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;

namespace ODataReferences.Services
{
    public class BlogDataService : DataService<BlogDataResources>
    {
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
        }
    }
}