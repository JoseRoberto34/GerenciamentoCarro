using GerenciamentoCarro.Dominio.Entidades;
using GerenciamentoCarro.Dominio.Interfaces.Repositorios;
using GerenciamentoCarro.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoCarro.Dominio.Servicos
{
    public class MarcaServico : ServicoBase<Marca>, IMarcaServico
    {
        public MarcaServico(IMarcaRepositorio repositorio)
            : base(repositorio)
        {
        }
    }
}
