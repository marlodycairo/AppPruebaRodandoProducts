using Infrastructure.Context;
using Infrastructure.Entities;
using Infrastructure.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validators
{
    public class ValidateCreateClientes : IClientes
    {
        public readonly ApplicationDbContext context;

        public ValidateCreateClientes(ApplicationDbContext context, IClientes clientes)
        {
            this.context = context;
        }

        public Clientes CreateClientes(Clientes clientes)
        {
            if (clientes == null)
            {
                throw new ArgumentNullException("Usuario no existe.");
            }
            return clientes;
        }

        public void DeleteClientes(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Clientes> GetClientes()
        {
            throw new NotImplementedException();
        }

        public Clientes GetClientesById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateClientes(int id, Clientes clientes)
        {
            throw new NotImplementedException();
        }
    }
}
