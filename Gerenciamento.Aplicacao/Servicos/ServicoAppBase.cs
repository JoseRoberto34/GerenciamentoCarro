using AutoMapper;
using GerenciamentoCarro.Aplicacao.DTO;
using GerenciamentoCarro.Aplicacao.Interfaces;
using GerenciamentoCarro.Dominio.Entidades;
using GerenciamentoCarro.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoCarro.Aplicacao.Servicos
{
    public class ServicoAppBase<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : BaseDTO
    {
        protected readonly IServicoBase<TEntidade> servico;
        protected readonly IMapper iMapper;

        public ServicoAppBase(IMapper iMapper, IServicoBase<TEntidade> servico)
            : base()
        {
            this.iMapper = iMapper;
            this.servico = servico;
        }
        public void Incluir(TEntidadeDTO entidade)
        {
            servico.Incluir(iMapper.Map<TEntidade>(entidade));
        }
        public void Alterar(TEntidadeDTO entidade)
        {
            servico.Alterar(iMapper.Map<TEntidade>(entidade));
        }
        public List<TEntidadeDTO> Listar()
        {
            return iMapper.Map<List<TEntidadeDTO>>(servico.Listar());
        }
     
        public TEntidadeDTO BuscarPorId(int id)
        {
            return iMapper.Map<TEntidadeDTO>(BuscarPorId(id));
        }
       
        public TEntidadeDTO BuscarPorNome(string Nome)
        {
            return iMapper.Map<TEntidadeDTO>(BuscarPorNome(Nome));
        }
        public void Excluir(TEntidadeDTO entidade)
        {
            servico.Excluir(iMapper.Map<TEntidade>(entidade));
        }

        
    }
}
