using Infrastructure.Context;
using Infrastructure.Entities;
using Infrastructure.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories.Repository
{
    public class ClientesRepo : IClientes
    {
        public readonly ApplicationDbContext context;
        public List<Clientes> clientes;

        public ClientesRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Clientes CreateClientes(Clientes clientes)
        {
            context.Clientes.Add(clientes);
            context.SaveChanges();
            return clientes;
        }

        public void DeleteClientes(int id)
        {
            var cliente = context.Clientes.FirstOrDefault(p => p.Identificacion == id);
            context.Remove(cliente);
            context.SaveChanges();
        }

        public IEnumerable<Clientes> GetClientes()
        {
            return clientes;
        }

        public Clientes GetClientesById(int id)
        {
            var cliente = context.Clientes.Find(id);
            return cliente;
        }

        public void UpdateClientes(int id, Clientes clientes)
        {
            clientes.Identificacion = id;
            context.Entry(clientes).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
