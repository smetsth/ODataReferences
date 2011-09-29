using System;
using System.Collections.Generic;
using System.Data.Services.Common;
using System.Runtime.Serialization;
using System.Text;

namespace ODataReferences.Contracts
{
    [DataServiceKey("Id")]
    [DataContract]
    public class BlogPost
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }
    }
}
