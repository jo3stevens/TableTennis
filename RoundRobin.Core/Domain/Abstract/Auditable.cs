using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using RoundRobin.Core.Interface;

namespace RoundRobin.Core.Domain.Abstract
{
    public abstract class Auditable : IAuditable, IEntity
    {
        public ObjectId Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public ObjectId CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ObjectId ModifiedBy { get; set; }
        public DateTime DeletedDate { get; set; }
        public ObjectId DeletedBy { get; set; }
    }
}
