using LojaUnit.Interfaces;
using LojaUnit.Models;
using LojaUnit.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LojaUnit.Controllers
{
    [ApiController]
    [Route("v1/pedidos")]
    public class PedidoController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Pedido Post(
            [FromServices] IClienteRepository clienteRepository,
            [FromServices] IPedidoRepository pedidoRepository,
            [FromServices] IUnitOfWork uow           
        )
        {
            try{
                var cliente = new Cliente { Nome = "Gabriel Veronesi"};
                var pedido = new Pedido { Numero = "001", Cliente = cliente };

                clienteRepository.Salvar(cliente);
                pedidoRepository.Salvar(pedido);

                uow.Commit();

                return pedido;
                }
                catch
                {
                    uow.RollBack(); //não vai fazer nada.. mais poderia ter algum método de rollback melhorzinho rsrsr
                    return null; //retornar null só pra não precisar tratar o erro.. só um teste
                }
        }
        
    }
}