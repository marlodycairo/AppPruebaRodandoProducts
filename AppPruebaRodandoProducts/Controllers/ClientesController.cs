using Domain.RepositoryService.IRepoService;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPruebaRodandoProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        public readonly IClientesRepoService clientesRepoService;

        public ClientesController(IClientesRepoService clientesRepoService)
        {
            this.clientesRepoService = clientesRepoService;
        }

        [HttpPost]
        public Clientes CreateClientes(Clientes clientes)
        {
            clientes = clientesRepoService.CreateClientes(clientes);
            return clientes;
        }

        [HttpGet]
        public IEnumerable<Clientes> GetAllProductos()
        {
            return clientesRepoService.GetClientes();
        }
    }
}
