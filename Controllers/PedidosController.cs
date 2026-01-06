using Microsoft.AspNetCore.Mvc;
using ApiPedidos.Data;
using ApiPedidos.Models;

namespace ApiPedidos.Controllers
{
    [ApiController]
    [Route("api/pedidos")]
    public class PedidosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedidosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_context.Pedidos.ToList());
        }

        [HttpPost]
        public IActionResult Criar(Pedido pedido)
        {
            if (pedido.ValorTotal <= 0)
                return BadRequest("Valor do pedido deve ser maior que zero.");

            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            return Created("", pedido);
        }

        [HttpPut("{id}/aprovar")]
        public IActionResult Aprovar(int id)
        {
            var pedido = _context.Pedidos.Find(id);
            if (pedido == null)
                return NotFound();

            pedido.Status = "Aprovado";
            _context.SaveChanges();

            return Ok(pedido);
        }

        [HttpPut("{id}/cancelar")]
        public IActionResult Cancelar(int id)
        {
            var pedido = _context.Pedidos.Find(id);
            if (pedido == null)
                return NotFound();

            pedido.Status = "Cancelado";
            _context.SaveChanges();

            return Ok(pedido);
        }
    }
}
