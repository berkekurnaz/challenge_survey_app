using AChallenge.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.DataAccess.Concrete
{
    public class ResponseRepository : BaseMongoRepository<Response>
    {

        public ResponseRepository(string mongoDbConnectionString, string dbName, string collectionName) : base(mongoDbConnectionString, dbName, collectionName)
        {

        }

    }
}
