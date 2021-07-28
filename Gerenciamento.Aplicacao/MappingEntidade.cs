using AutoMapper;
using GerenciamentoCarro.Aplicacao.DTO;
using GerenciamentoCarro.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoCarro.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Carro, CarroDTO>();
            CreateMap<CarroDTO, Carro>();
            CreateMap<Marca, MarcaDTO>();
            CreateMap<MarcaDTO, Marca>();
        }
    }
}
