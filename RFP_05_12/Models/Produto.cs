using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFP_05_12.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Importado { get; set; }
        public bool Revenda { get; set; }
        public bool Publico { get; set; }
        public string Especs { get; set; }

    }
}
