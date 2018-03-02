using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Lote
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Produto { get; set; }
        public DateTime? Validade { get; set; }
        public float Quantidade { get; set; }
        public decimal PrecoCusto { get; set; }
        public bool Ativo { get; set; }
    }
}
