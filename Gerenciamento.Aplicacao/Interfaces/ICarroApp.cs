using GerenciamentoCarro.Aplicacao.DTO;
using GerenciamentoCarro.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoCarro.Aplicacao.Interfaces
{
    interface ICarroApp : IAppBase<Carro, CarroDTO>
    {
    }
}
