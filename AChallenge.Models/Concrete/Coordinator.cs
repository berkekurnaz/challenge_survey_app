using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.Models.Concrete
{
    public class Coordinator : MongoBaseModel
    {

        [BsonElement("Username")]
        public string Username { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("Mail")]
        public string Mail { get; set; }

        [BsonElement("NameSurname")]
        public string NameSurname { get; set; }

    }
}
