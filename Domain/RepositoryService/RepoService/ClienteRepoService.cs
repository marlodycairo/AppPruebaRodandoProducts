using Domain.RepositoryService.IRepoService;
using Infrastructure.Entities;
using Infrastructure.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RepositoryService.RepoService
{
    public class ClienteRepoService : IClientesRepoService
    {
        public readonly IClientes clientesRepo;

        public ClienteRepoService(IClientes clientes)
        {
            clientesRepo = clientes;
        }
        public Clientes CreateClientes(Clientes clientes)
        {
            clientesRepo.CreateClientes(clientes);

            return clientes;
        }

        public void DeleteClientes(int id)
        {
            clientesRepo.DeleteClientes(id);
        }

        public IEnumerable<Clientes> GetClientes()
        {
            return clientesRepo.GetClientes();
        }

        public Clientes GetClientesById(int id)
        {
            return clientesRepo.GetClientesById(id);
        }

        public void UpdateClientes(int id, Clientes clientes)
        {
            clientesRepo.UpdateClientes(id, clientes);
        }
    }
}
