using ProjetoModeloDDD.Dominio.Interfaces.Repositories;
using ProjetoModeloDDD.Dominio.Entities;

namespace ProjetoModeloDDD.Infra.Dados.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
