using AChallenge.Models.Abstract;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.Models.Concrete
{
    public class MongoBaseModel : IEntity
    {
        public ObjectId Id { get; set; }
    }
}
