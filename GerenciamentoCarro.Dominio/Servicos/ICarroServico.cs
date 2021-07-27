using GerenciamentoCarro.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoCarro.Dominio.Servicos
{
    public interface ICarroServico
    {
        public void Incluir(Carro carro);
        public List<Carro> Lista(Carro carro);
        public int BuscarPorId(int id);
        public int Altera(Carro carro);
        public int Delete(int id);
    }
}
