using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class MeioPagamento
    {

        public MeioPagamento() => CriadoEm = DateTime.Now;
        public int MeioPagamentoId { get; set; }
        public bool Estornavel{ get; set; }
        public string MetodoDePagamento { get; set; }
       
        public DateTime CriadoEm { get; set; }
    }
}
