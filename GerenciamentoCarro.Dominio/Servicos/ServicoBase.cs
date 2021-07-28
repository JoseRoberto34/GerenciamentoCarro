using GerenciamentoCarro.Dominio.Entidades;
using GerenciamentoCarro.Dominio.Interfaces.Repositorios;
using GerenciamentoCarro.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoCarro.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade> where TEntidade : EntidadeBase
    {
        protected readonly IRepositorioBase<TEntidade> repositorio;
        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            this.repositorio = repositorio;
        }
        public void Incluir(TEntidade entidade)
        {
            repositorio.Incluir(entidade);
        }
        public void Alterar(TEntidade entidade)
        {
            repositorio.Alterar(entidade);
        }
        public List<TEntidade> Listar()
        {
            return repositorio.Listar();
        }
        public int BuscarPorId(int id)
        {
            return repositorio.BuscarPorId(id);
        }
        public string BuscarPorNome(string Nome)
        {
            return repositorio.BuscarPorNome(Nome);
        }
        public void Excluir(TEntidade entidade)
        {
            repositorio.Excluir(entidade);
        }

    }
}
