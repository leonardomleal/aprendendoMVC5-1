using ProjetoModeloDDD.Dominio.Interfaces.Repositories;
using ProjetoModeloDDD.Dominio.Interfaces.Services;
using ProjetoModeloDDD.Dominio.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Dominio.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}