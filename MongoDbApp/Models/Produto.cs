using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoDbApp.Models
{
    public class Produto
    {
        public ObjectId Id { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public string Quantidade { get; set; }
    }
}
