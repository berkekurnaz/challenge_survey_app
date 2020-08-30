using AChallenge.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.DataAccess.Concrete
{
    public class CoordinatorRepository : BaseMongoRepository<Coordinator>
    {

        public CoordinatorRepository(string mongoDbConnectionString, string dbName, string collectionName) : base(mongoDbConnectionString, dbName, collectionName)
        {

        }

    }
}
