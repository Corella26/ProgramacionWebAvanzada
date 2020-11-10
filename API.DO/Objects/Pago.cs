using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.DO.Objects
{
    public class Pago
    {
        [BsonId]
        public ObjectId IdPago { get; set; }
        public int IdUsuario { get; set; }
        public int IdUnidad { get; set; }
        public int Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public bool Estado { get; set; }
    }
}
