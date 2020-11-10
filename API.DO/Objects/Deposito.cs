using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.DO.Objects
{
    public class Deposito
    {
        [BsonId]
        public ObjectId IdDeposito { get; set; }
        public ObjectId IdUsuario { get; set; }
        public int Monto { get; set; }
        public DateTime FechaDeposito { get; set; }
        public bool Estado { get; set; }
    }
}
