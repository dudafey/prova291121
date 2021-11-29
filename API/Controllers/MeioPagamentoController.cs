using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class MeioPagamentoController : Controller
    {

        private readonly DataContext _context;
        //Construtor
        public MeioPagamentoController(DataContext context) => _context = context;

        //POST: api/usuario/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] MeioPagamento meioPagamento)
        {
            MeioPagamento meioPagamentoExistente = _context.MeiosPagamento.FirstOrDefault(u => u.MetodoDePagamento == meioPagamento.MetodoDePagamento);
            if (meioPagamentoExistente != null)
            {
                return BadRequest(new { message = "Este metodo de pagamento já existe na base" });
            }
            _context.MeiosPagamento.Add(meioPagamento);
            _context.SaveChanges();
            return Created("", meioPagamento);
        }
    }
}
