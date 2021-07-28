using GerenciamentoCarro.Aplicacao.DTO;
using GerenciamentoCarro.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoCarro.Aplicacao.Interfaces
{
    public interface IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : BaseDTO
    {
        public void Incluir(TEntidadeDTO entidade);
        public List<TEntidadeDTO> Listar();
        public TEntidadeDTO BuscarPorId(int id);
        public TEntidadeDTO BuscarPorNome(string Nome);
        public void Alterar(TEntidadeDTO entidade);
        public void Excluir(TEntidadeDTO entidade);
    }
}
