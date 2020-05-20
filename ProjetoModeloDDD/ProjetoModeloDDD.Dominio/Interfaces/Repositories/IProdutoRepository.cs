using ProjetoModeloDDD.Dominio.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}