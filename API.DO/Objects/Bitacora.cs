using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.DO.Objects
{
    public class Bitacora
    {
        [BsonId]
        public ObjectId IdBitacora { get; set; }
        public string Accion { get; set; }
        public string Error { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public bool Estado { get; set; }
    }
}
