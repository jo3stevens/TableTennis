using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using RoundRobin.Core.Helper.Mongo;
using RoundRobin.Core.Interface;

namespace RoundRobin.Core.Service.Abstract
{
    public abstract class BaseService<T> where T : IEntity
    {
        public DbHelper<T> Db { get; private set; }
        public IEntity CurrentUser { get; set; }

        protected BaseService()
        {
            Db = new DbHelper<T>();
        }

        public virtual T Get(ObjectId id)
        {
            return Db.Collection.FindOne(Query.EQ("_id", id));
        }

        public virtual void Create(T obj)
        {
            if (obj is IAuditable)
            {
                ((IAuditable)obj).CreatedDate = DateTime.UtcNow;
                ((IAuditable)obj).CreatedBy = CurrentUser.Id;
            }

            Db.Collection.Save(obj);
        }

        public virtual void Edit(T obj)
        {
            if (obj is IAuditable)
            {
                ((IAuditable)obj).ModifiedDate = DateTime.UtcNow;
                ((IAuditable)obj).ModifiedBy = CurrentUser.Id;
            }
        }

        public virtual void Remove(T obj)
        {
            if (obj is IAuditable)
            {
                Db.Collection.Update(
                    Query.EQ("_id", obj.Id),
                    Update.Set("DeletedDate", DateTime.UtcNow).Set("DeletedBy", CurrentUser.Id)
                );
            }
            else
            {
                Db.Collection.Remove(Query.EQ("_id", obj.Id));
            }
        }
    }
}
