using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories.IRepository
{
    public interface IClientes
    {
        IEnumerable<Clientes> GetClientes();

        Clientes GetClientesById(int id);

        Clientes CreateClientes(Clientes clientes);

        void UpdateClientes(int id, Clientes clientes);

        void DeleteClientes(int id);
    }
}
