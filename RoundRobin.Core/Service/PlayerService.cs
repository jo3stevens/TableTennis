using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using RoundRobin.Core.Domain;
using RoundRobin.Core.Helper.Mongo;
using RoundRobin.Core.Service.Abstract;
using RoundRobin.Core.Service.Interface;

namespace RoundRobin.Core.Service
{
    public class PlayerService : BaseService<Player>, IPlayerService
    {

    }
}
