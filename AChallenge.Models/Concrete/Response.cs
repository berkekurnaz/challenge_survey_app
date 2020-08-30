using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.Models.Concrete
{
    public class Response : MongoBaseModel
    {

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Answers")]
        public string[] Answers { get; set; }

        [BsonElement("SurveyId")]
        public ObjectId SurveyId { get; set; }

        [BsonElement("RespondentId")]
        public ObjectId RespondentId { get; set; }

    }
}
