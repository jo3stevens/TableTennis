using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace RoundRobin.Core.Interface
{
    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        ObjectId CreatedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        ObjectId ModifiedBy { get; set; }
        DateTime DeletedDate { get; set; }
        ObjectId DeletedBy { get; set; }
    }
}
