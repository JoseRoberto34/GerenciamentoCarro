using GerenciamentoCarro.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoCarro.Dominio.Interfaces.Repositorios
{
    public interface ICarroRepositorio
    {
        public void Incluir(Carro carro);
        public List<Carro> Lista(Carro carro);
        public int BuscarPorId(int id);
        public int Altera(Carro carro);
        public int Delete(int id);
    }
}
