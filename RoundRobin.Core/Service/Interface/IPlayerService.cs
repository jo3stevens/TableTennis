using MongoDB.Bson;
using RoundRobin.Core.Domain;
using RoundRobin.Core.Interface;

namespace RoundRobin.Core.Service.Interface
{
    public interface IPlayerService
    {
        IEntity CurrentUser { get; set; }
        Player Get(ObjectId id);
        void Create(Player obj);
        void Edit(Player obj);
        void Remove(Player obj);
    }
}