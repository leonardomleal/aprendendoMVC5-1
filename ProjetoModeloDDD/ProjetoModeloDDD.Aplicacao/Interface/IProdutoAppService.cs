using ProjetoModeloDDD.Dominio.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Aplicacao.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
