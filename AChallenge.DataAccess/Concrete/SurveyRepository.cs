using AChallenge.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.DataAccess.Concrete
{
    public class SurveyRepository : BaseMongoRepository<Survey>
    {

        public SurveyRepository(string mongoDbConnectionString, string dbName, string collectionName) : base(mongoDbConnectionString, dbName, collectionName)
        {

        }

    }
}
