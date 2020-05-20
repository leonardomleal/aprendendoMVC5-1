using ProjetoModeloDDD.Dominio.Interfaces.Repositories;
using ProjetoModeloDDD.Dominio.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Dados.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}