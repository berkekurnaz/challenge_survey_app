using AChallenge.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.DataAccess.Concrete
{
    public class RespondentRepository : BaseMongoRepository<Respondent>
    {

        public RespondentRepository(string mongoDbConnectionString, string dbName, string collectionName) : base(mongoDbConnectionString, dbName, collectionName)
        {

        }

    }
}
