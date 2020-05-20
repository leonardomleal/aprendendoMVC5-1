﻿using ProjetoModeloDDD.Dominio.Interfaces.Repositories;
using ProjetoModeloDDD.Dominio.Interfaces.Services;
using ProjetoModeloDDD.Dominio.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}