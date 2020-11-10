using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace API.DO.Objects
{
    public class Linea
    {
        public ObjectId IdLinea { get; set; }
        public string Descripcion { get; set; }
        public int Monto { get; set; }
        public int CodigoCTP { get; set; }
        public bool Estado { get; set; }
    }
}
