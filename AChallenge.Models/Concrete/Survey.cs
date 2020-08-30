using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.Models.Concrete
{
    public class Survey : MongoBaseModel
    {
        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("IsVisible")]
        public string IsVisible { get; set; }

        [BsonElement("CreatedDate")]
        public string CreatedDate { get; set; }

        [BsonElement("Questions")]
        public List<Question> Questions { get; set; }

        [BsonElement("CoordinatorId")]
        public ObjectId CoordinatorId { get; set; }

    }
}
