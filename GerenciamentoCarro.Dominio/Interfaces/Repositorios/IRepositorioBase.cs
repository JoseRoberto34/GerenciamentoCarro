using GerenciamentoCarro.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoCarro.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntidade>
        where TEntidade : EntidadeBase
    {
        public void Incluir(TEntidade entidade);
        public List<TEntidade> Listar();
        public int BuscarPorId(int id);
        public string BuscarPorNome(string Nome);
        public void Alterar(TEntidade entidade);
        public void Excluir(TEntidade entidade);

    }
}
