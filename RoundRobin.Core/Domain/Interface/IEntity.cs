using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace RoundRobin.Core.Interface
{
    public interface IEntity
    {
        ObjectId Id { get; set; }
    }
}
