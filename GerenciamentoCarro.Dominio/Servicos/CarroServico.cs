using GerenciamentoCarro.Dominio.Entidades;
using GerenciamentoCarro.Dominio.Interfaces.Repositorios;
using GerenciamentoCarro.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoCarro.Dominio.Servicos
{
    public class CarroServico : ServicoBase<Carro>, ICarroServico
    {
        public CarroServico(ICarroRepositorio repositorio)
            : base(repositorio)
        {
        }
    }
}
