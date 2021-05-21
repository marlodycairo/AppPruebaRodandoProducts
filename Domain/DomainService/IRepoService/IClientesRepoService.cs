using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RepositoryService.IRepoService
{
    public interface IClientesRepoService
    {
        IEnumerable<Clientes> GetClientes();

        Clientes GetClientesById(int id);

        Clientes CreateClientes(Clientes clientes);

        void UpdateClientes(int id, Clientes clientes);

        void DeleteClientes(int id);
    }
}
